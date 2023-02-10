using System;
using UnityEngine.EventSystems;

public interface IButtonYHandler : IEventSystemHandler
{
	void OnButtonY(BaseEventData eventData);
}
