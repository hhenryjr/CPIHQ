using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnetCloudantWebstarter.Models.Requests.UsersData
{
    public class UserInfoUpdate : UserInfoAddRequest
    {
        [Required]
        public int Id { get; set; }

        public int CoverPhotoId { get; set; }

        public int AvatarPhotoId { get; set; }
    }
}