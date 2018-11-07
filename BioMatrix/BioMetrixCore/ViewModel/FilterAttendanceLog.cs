﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMetrixCore.ViewModel
{
    class FilterAttendanceLog
    {
        public int MachineNumber { get; set; }
        public int PersonalId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime AttendanceDateTime { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
    }
}
