using BallsCommon;

namespace AngryBirdWFA
{

    //Хотел сделать натяжение верёвки, но чет сил не хватило пока :)
    public class Rope : Ball
    {
        public Rope(Label map) : base(map)
        {
        }

        public void MovePoint(float x, float y)
        {
            centerX = x;
            centerY = y;
            Show();
        }
    }
}
