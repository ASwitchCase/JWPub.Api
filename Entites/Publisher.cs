using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace JWPub.Api.Entites
{
    public class Publisher
    {
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]
        [StringLength(20)]
        public required string SpiritualStatus { get; set; }
        [Required]
        [StringLength(30)]
        public required string Congregation { get; set; }
        public Guid Id { get; set; }

    }
}