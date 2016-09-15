//npm install gulp-htmlmin gulp-imagemin imagemin-pngcrush gulp-minify-css gulp-jshint gulp-uglify gulp-concat gulp-rename gulp-notify gulp-base64 --save-dev
// ���� gulp
var gulp = require('gulp');

// �������
var htmlmin = require('gulp-htmlmin'), //htmlѹ��
    imagemin = require('gulp-imagemin'),//ͼƬѹ��
    base64 = require('gulp-base64'),//ͼƬתbase64
    pngcrush = require('imagemin-pngcrush'),
    minifycss = require('gulp-minify-css'),//cssѹ��
    jshint = require('gulp-jshint'),//js���
    uglify = require('gulp-uglify'),//jsѹ��
    concat = require('gulp-concat'),//�ļ��ϲ�
    rename = require('gulp-rename'),//�ļ�����
    notify = require('gulp-notify');//��ʾ��Ϣ

// ѹ��html
gulp.task('html', function () {
    return gulp.src('src/*.html')
      .pipe(htmlmin({ collapseWhitespace: true }))
      .pipe(gulp.dest('./dest'))
      .pipe(notify({ message: 'html task ok' }));

});

// ѹ��ͼƬ
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

// �ϲ���ѹ����������css
gulp.task('css', function () {
    return gulp.src('src/css/*.css')
      .pipe(concat('main.css'))
      .pipe(gulp.dest('dest/css'))
      .pipe(rename({ suffix: '.min' }))
      .pipe(minifycss())
      .pipe(gulp.dest('dest/css'))
      .pipe(notify({ message: 'css task ok' }));
});

// ���js
gulp.task('lint', function () {
    return gulp.src('src/js/*.js')
      .pipe(jshint())
      .pipe(jshint.reporter('default'))
      .pipe(notify({ message: 'lint task ok' }));
});

// �ϲ���ѹ��js�ļ�
gulp.task('js', function () {
    return gulp.src('src/js/*.js')
      .pipe(concat('all.js'))
      .pipe(gulp.dest('dest/js'))
      .pipe(rename({ suffix: '.min' }))
      .pipe(uglify())
      .pipe(gulp.dest('dest/js'))
      .pipe(notify({ message: 'js task ok' }));
});

// Ĭ������
gulp.task('default', function () {
    gulp.run('img', 'css', 'lint', 'js', 'html');

    // ����html�ļ��仯
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