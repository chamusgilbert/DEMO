using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClock
{
	public class JobPunch
	{
		public int Id { get; set; }
		public string JobNo { get; set; }
		public short? StepNo { get; set; }
		public DateTime Time { get; set; }
		public short EmplCode { get; set; }
		public int? QtyToReport { get; set; }

		public bool IsValid()
		{
			return !string.IsNullOrWhiteSpace(JobNo) && StepNo != null && EmplCode != 0 && (QtyToReport != 0 && QtyToReport != null);
		}
	}
}
