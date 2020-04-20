using Robocode;

namespace CAP4053.Student
{
    public class SampleStudentBot : TeamRobot {
        override
        public void Run()
        {
            while(true)
            {
                Ahead(100);
                TurnGunRight(360);
                Back(100);
                TurnGunRight(360);
            }
        }

        override
        public void OnScannedRobot(ScannedRobotEvent e) {
            Fire(100);
        }
    }
}
