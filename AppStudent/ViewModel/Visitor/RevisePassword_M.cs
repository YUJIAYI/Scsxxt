﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicePlatform.Areas.AppStudent.ViewModel.Visitor
{
    public class RevisePassword_M
    {
        public static RevisePassword_M ToViewModel(List<SelectListItem> SchoolIItems)
        {
            return new RevisePassword_M()
            {
                _SchoolIItems = SchoolIItems
            };
        }

        public string unitid { get; set; }
        [Required(ErrorMessage = "请填写用户名")]
        public string userid { get; set; }
        [Required(ErrorMessage = "请填写新密码")]
        public string NewPsw1 { get; set; }
        [Required(ErrorMessage = "请确定密码")]
        public string NewPsw2 { get; set; }
        public List<SelectListItem> _SchoolIItems { get; set; }
    }
}