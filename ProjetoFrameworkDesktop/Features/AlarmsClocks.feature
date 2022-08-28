Feature: AlarmsClocks

As an alarms an clocks simple user
I Want to schedule my meetings
In order to do not miss any appointment

@Test01
Scenario: Add an alarm
	Given Alarms&Clocks app is opened
	When the user adds a new alarm
	Then the new alarm should be displayed at alarms page
