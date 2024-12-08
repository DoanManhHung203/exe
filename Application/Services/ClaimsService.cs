using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Application.Interfaces;

namespace Application.Services
{
    public class ClaimsService : IClaimsService
    {

        public ClaimsService(IHttpContextAccessor httpContextAccessor) {
            var Id = httpContextAccessor.HttpContext?.User?.FindFirst("userId").Value;
            GetCurrentUserId = string.IsNullOrEmpty(Id) ? Guid.Empty : Guid.Parse(Id);
        }

        public Guid GetCurrentUserId { get; }
    }
}
