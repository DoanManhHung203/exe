using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Services.Services
{
    public class CurrentTime : ICurrentTime
    {
        public DateTime GetCurentTime() => DateTime.UtcNow; 
    }
}
