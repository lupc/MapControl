﻿#region 文件说明 Info 
/* ========================================================================
* 【本类功能概述】 
* 
* 作者：zzl 时间：2018/9/13 11:19:05 
* 文件名：SizeLatLng 
* 版本：V1.0.1 
* 
* 修改者：   时间： 
* 修改说明： 
* ========================================================================
*/ 
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace BMap.Core.Model
{
    public class SizeLong:BSize<long>
    {
        public SizeLong()
        {

        }
        public SizeLong(long w,long h):base(w,h)
        {

        }
     
        
    }
}
