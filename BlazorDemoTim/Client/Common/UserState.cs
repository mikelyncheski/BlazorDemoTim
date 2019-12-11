using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoTim.Client.Common
{
	public class UserState
	{
		public int Counter { get; private set; } = 0;
		public int? TodaysTemperature { get; private set; }
		public int? TotalRides { get; private set; }
		public int? TotalMileage { get; private set; }

		private Action _stateHasChanged;


		public UserState(Action stateHasChanged)
		{
			_stateHasChanged = stateHasChanged;
		}


		public void SetCounter(int newValue)
		{
			Counter = newValue;
			_stateHasChanged();
		}


		public void SetTemperature(int? newValue)
		{
			TodaysTemperature = newValue;
			_stateHasChanged();
		}



		public void SetStats(int? totalRides, int? totalMileage)
		{
			TotalRides = totalRides;
			TotalMileage = totalMileage;
			_stateHasChanged();
		}
	}
}
