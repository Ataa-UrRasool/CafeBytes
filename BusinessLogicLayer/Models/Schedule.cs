using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.BusinessLogicLayer.Models
{
	internal class Schedule
	{
		public int Id { get; set; }
		public TimeOnly ScheduleTime { get; set; }
		public DateOnly ScheduleDate { get; set; }
	}

}
