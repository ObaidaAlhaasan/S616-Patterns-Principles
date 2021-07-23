using System.Collections.Generic;

namespace Design_Patterns_OOP.FlyWeight
{
    public class PointsService
    {
        public List<Point> GetPoints()
        {
            var cafe = PointIconFactory.Get(PointIconType.Cafe);
            var hospital = PointIconFactory.Get(PointIconType.Hospital);
            var restaurant = PointIconFactory.Get(PointIconType.Restaurant);
            var point1 = new Point(10, 20, cafe);
            var point2 = new Point(10, 20, hospital);
            var point3 = new Point(10, 20, restaurant);
            point1.Draw();
            point2.Draw();
            point3.Draw();

            return new List<Point> {point1, point2, point3};
        }
    }
}