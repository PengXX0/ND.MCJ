using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ND.MCJ.Framework
{
    public class Network
    {
        public Network() { }

        #region 根据IP判断网络类型
        /// <summary>
        /// 判断指定IP是否为广域网IP
        /// ABC类外的IP地址为广域网IP
        /// A类:10.0.0.0~10.255.255.255
        /// B类:172.16.0.0~172.31.255.255
        /// C类:192.168.0.0~192.168.255.255
        /// </summary>
        /// <param name="ipAddress">要测试的IP地址</param>
        /// <returns>地址分类</returns>
        /// <remarks>0:无效IP,1:局域网IP,2:广域网IP</remarks>
        public static NetType GetIpType(string ipAddress)
        {
            if (ipAddress == "127.0.0.1" || ipAddress == "0.0.0.0") { return NetType.LAN; }
            string[] ipAddressList = ipAddress.Split('.');
            int ipAddressTemp;

            //检查IP地址是否有效
            if (ipAddressList.Length != 4) { return 0; }
            if (!(int.TryParse(ipAddressList[0], out ipAddressTemp) && int.TryParse(ipAddressList[1], out ipAddressTemp)
                && int.TryParse(ipAddressList[2], out ipAddressTemp) && int.TryParse(ipAddressList[3], out ipAddressTemp)))
            {
                return NetType.Invalid;
            }
            if (!(int.Parse(ipAddressList[0]) >= 0 && int.Parse(ipAddressList[0]) <= 255
                    && int.Parse(ipAddressList[1]) >= 0 && int.Parse(ipAddressList[1]) <= 255
                    && int.Parse(ipAddressList[2]) >= 0 && int.Parse(ipAddressList[2]) <= 255
                    && int.Parse(ipAddressList[3]) >= 0 && int.Parse(ipAddressList[3]) <= 255))
            {
                return 0;
            }

            //局域网IP
            if (int.Parse(ipAddressList[0]) == 10
                    || (int.Parse(ipAddressList[0]) == 172 && int.Parse(ipAddressList[1]) >= 16 && int.Parse(ipAddressList[1]) <= 31)
                    || (int.Parse(ipAddressList[0]) == 192 && int.Parse(ipAddressList[1]) == 168))
            {
                return NetType.LAN; ;
            }
            return NetType.WAN;
        }

        /// <summary>
        /// 网络类型
        /// </summary>
        public enum NetType
        {
            /// <summary>
            /// 无效IP
            /// </summary>
            Invalid = 0,
            /// <summary>
            /// 局域网
            /// </summary>
            LAN = 1,
            /// <summary>
            /// 广域网（公网）
            /// </summary>
            WAN = 2
        }

        #endregion
    }
}
