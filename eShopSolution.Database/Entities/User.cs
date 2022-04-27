using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Database.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        [Required]
        public int Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(10)]
        public string FirstSecurityString { get; set; }

        [StringLength(10)]
        public string LastSecurityString { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
        public int RoleId { get; set; }

        public DateTimeOffset? LastLogin { get; set; }
        /// <summary>
        /// Ngày tạo dữ liệu
        /// </summary>
        public DateTimeOffset CreatedAt { set; get; }
        /// <summary>
        /// Ngày cập nhật dữ liệu
        /// </summary>
        public DateTimeOffset? UpdatedAt { set; get; }
        public virtual Role Role { set; get; }
    }
}
