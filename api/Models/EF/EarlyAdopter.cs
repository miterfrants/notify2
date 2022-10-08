using System;
using Homo.Api;

namespace Homo.AuthApi
{
    public partial class EarlyAdopter
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? EditedAt { get; set; }
        public long? EditedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        [MaxLength(128)]
        public string Email { get; set; }

        [MaxLength(512)]
        public string Phone { get; set; }
        public Decimal Fee { get; set; }
    }
}
