//npm install gulp-htmlmin gulp-imagemin imagemin-pngcrush gulp-minify-css gulp-jshint gulp-uglify gulp-concat gulp-rename gulp-notify gulp-base64 --save-dev
// 引入 gulp
var gulp = require('gulp');

// 引入组件
var htmlmin = require('gulp-htmlmin'), //html压缩
    imagemin = require('gulp-imagemin'),//图片压缩
    base64 = require('gulp-base64'),//图片转base64
    pngcrush = require('imagemin-pngcrush'),
    minifycss = require('gulp-minify-css'),//css压缩
    jshint = require('gulp-jshint'),//js检测
    uglify = require('gulp-uglify'),//js压缩
    concat = require('gulp-concat'),//文件合并
    rename = require('gulp-rename'),//文件更名
    notify = require('gulp-notify');//提示信息

// 压缩html
gulp.task('html', function () {
    return gulp.src('src/*.html')
      .pipe(htmlmin({ collapseWhitespace: true }))
      .pipe(gulp.dest('./dest'))
      .pipe(notify({ message: 'html task ok' }));

});

// 压缩图片
gulp.task('img', function () {
    return gulp.src('src/images/*')
      .pipe(imagemin({
          progressive: true,
          svgoPlugins: [{ removeViewBox: false }],
          use: [pngcrush()]
      }))
      .pipe(gulp.dest('./dest/images/'))
      .pipe(notify({ message: 'img task ok' }));
});



var config = {
    src: developmentAssets + '/css/*.css',
    dest: developmentAssets + '/css',
    options: {
        baseDir: build,
        extensions: ['png'],
        maxImageSize: 20 * 1024, // bytes
        debug: false
    }
};

gulp.task('base64', ['sass'], function () {
    return gulp.src(config.src)
      .pipe(base64(config.options))
      .pipe(gulp.dest(config.dest));
});

// 合并、压缩、重命名css
gulp.task('css', function () {
    return gulp.src('src/css/*.css')
      .pipe(concat('main.css'))
      .pipe(gulp.dest('dest/css'))
      .pipe(rename({ suffix: '.min' }))
      .pipe(minifycss())
      .pipe(gulp.dest('dest/css'))
      .pipe(notify({ message: 'css task ok' }));
});

// 检查js
gulp.task('lint', function () {
    return gulp.src('src/js/*.js')
      .pipe(jshint())
      .pipe(jshint.reporter('default'))
      .pipe(notify({ message: 'lint task ok' }));
});

// 合并、压缩js文件
gulp.task('js', function () {
    return gulp.src('src/js/*.js')
      .pipe(concat('all.js'))
      .pipe(gulp.dest('dest/js'))
      .pipe(rename({ suffix: '.min' }))
      .pipe(uglify())
      .pipe(gulp.dest('dest/js'))
      .pipe(notify({ message: 'js task ok' }));
});

// 默认任务
gulp.task('default', function () {
    gulp.run('img', 'css', 'lint', 'js', 'html');

    // 监听html文件变化
    gulp.watch('src/*.html', function () {
        gulp.run('html');
    });

    // Watch .css files
    gulp.watch('src/css/*.css', ['css']);

    // Watch .js files
    gulp.watch('src/js/*.js', ['lint', 'js']);

    // Watch image files
    gulp.watch('src/images/*', ['img']);
});