namespace OneBitTask.Web.ViewModels
{
    using System;
    using System.Linq.Expressions;
    using System.ComponentModel.DataAnnotations;

    using Models;

    public class UserViewModel
    {
        public static Expression<Func<User, UserViewModel>> FromUser
        {
            get
            {
                return
                    user =>
                        new UserViewModel
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            PhotoUrl = user.PhotoUrl,
                            Telephone = user.Telephone,
                            Sex = user.Sex,
                            Status = user.Status,
                        };
            }
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        public SexType Sex { get; set; }

        public string Telephone { get; set; }

        public string PhotoUrl { get; set; }

        public StatusType Status { get; set; }
    }
}
