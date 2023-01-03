using FactoryAsync.Factory;

var meeting = await CallFactory.InstantiateARoom(RoomType.GOOGLE_MEETING, "Call for business", 120);
Console.WriteLine("Type name " + meeting.GetType().Name + " | call name: " + meeting.NameOfTheRoom);