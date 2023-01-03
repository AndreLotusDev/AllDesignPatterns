using FactoryAsync.Classes;

namespace FactoryAsync.Factory
{
    public class CallFactory
    {
        public static async Task<CallBaseClass> InstantiateARoom(RoomType type, string nameOfTheRoom, int duration = 30)
        {
            if(type == RoomType.GOOGLE_MEETING)
            {
                await ConnectWithMainServer(type);
                return new GoogleMeetingRoom(nameOfTheRoom, duration);
            }
            else if(type == RoomType.JITSI)
            {
                await ConnectWithMainServer(type);
                return new JitsiMeetRoom(nameOfTheRoom, duration);
            }
            else
            {
                throw new Exception("Invalid meeting type");
            }
        }

        private static async Task<string> ConnectWithMainServer(RoomType type)
        {
            var credentials = "";

            Console.WriteLine("Connecting with the meeting room..");
            await Task.Delay(500);

            if (type == RoomType.GOOGLE_MEETING)
            {
                credentials = "GOOGLE_MEETING_CREDENTIAL";
            }
            else if (type == RoomType.JITSI)
            {
                credentials = "JITSI";
            }
            else
            {
                credentials = "invalid credentials";
                throw new Exception("Invalid meeting type");
            }
            
            Console.WriteLine("Finishing the handshake...");
            await Task.Delay(500);

            Console.WriteLine("Returning the credentials....");
            await Task.Delay(3000);

            return credentials;
        }
    }

    public enum RoomType
    {
        GOOGLE_MEETING,
        JITSI
    }
}
