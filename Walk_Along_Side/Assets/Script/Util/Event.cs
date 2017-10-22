using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cumstom_Event
{
	public abstract class Event {
		public delegate void Handler(Event e);
	}

	public class DoorSeenEvent: Event{

	}
	public class DoorMoveEvent: Event{

	}
	public class DoorResetEvent: Event{
		
	}
}
