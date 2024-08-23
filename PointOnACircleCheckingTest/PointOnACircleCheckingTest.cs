using PointOnACircleChecking;

namespace PointOnACircleCheckingTest
{
    public class PointOnACircleCheckingTest
    {
        [Theory]
        [InlineData(0,0,true)]
        [InlineData(6,0,false)]
        [InlineData(5,0,true)]
        public void IsPointInsideCircle_WithGivenPoints_ShouldReturnIfIsTrueOrFalse(int x, int y, bool expected)
        {
            bool result = PointOnACircleChecking.IsPointInsideCircle.(x, y);
            Assert.Equal(expected, result);
        }
    }
}