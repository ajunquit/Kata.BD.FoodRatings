namespace Kata.BD.FoodRatings.Test
{
    public class UnitTest1
    {
        KataFoodRating foodRating;
        public UnitTest1()
        {
            foodRating = new KataFoodRating();
        }

        [Fact]
        public void Test1_ValidInput_ReturnCorrecResult()
        {
            int n = 4;

            int[][] ratings = new int[][]
            {
                new int[] { 512, 2 },
                new int[] { 123, 3 },
                new int[] { 987, 4 },
                new int[] { 123, 5}
            };

            int expected = 123;

            int actual = foodRating.FoodRatings(n, ratings);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2_ValidInput_ReturnCorrecResult()
        {
            int n = 5;

            int[][] ratings = new int[][]
            {
                new int[] { 987654423, 4 },
                new int[] { 987654220, 5 },
                new int[] { 987654202, 4 },
                new int[] { 987654250, 1 },
                new int[] { 987654419, 5 }
            };

            int expected = 987654220;

            int actual = foodRating.FoodRatings(n, ratings);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test3_ValidInput_ReturnCorrecResult()
        {
            int n = 5;

            int[][] ratings = new int[][]
            {
                new int[] { 171, 3 },
                new int[] { 478, 3 },
                new int[] { 092, 4 },
                new int[] { 421, 3 },
                new int[] { 1, 4 }
            };

            int expected = 1;

            int actual = foodRating.FoodRatings(n, ratings);
            Assert.Equal(expected, actual);

        }


        [Fact]
        public void Test4_ValidInput_ReturnCorrecResult()
        {
            int n = 9;

            int[][] ratings = new int[][]
            {
                new int[] { 321, 5 },
                new int[] { 122, 4 },
                new int[] { 321, 2 },
                new int[] { 1, 5 },
                new int[] { 478, 3 },
                new int[] { 321, 3 },
                new int[] { 1, 1 },
                new int[] { 25, 2 },
                new int[] { 122, 3 }
            };

            int expected = 122;

            int actual = foodRating.FoodRatings(n, ratings);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test5_InconsistenceInputs_ReturnArgumentException()
        {
            int n = 4;

            int[][] ratings = new int[][]
            {
                new int[] { 171, 3 },
                new int[] { 478, 3 },
                new int[] { 092, 4 },
                new int[] { 421, 3 },
                new int[] { 1, 4 }
            };

            Assert.Throws<ArgumentException>( () => foodRating.FoodRatings(n, ratings));

        }

        [Fact]
        public void Test6_EmptyMatrix_ReturnNullReferenceException()
        {
            int n = 0;

            int[][] ratings = new int[][]
            {
            };

            Assert.Throws<NullReferenceException>(() => foodRating.FoodRatings(n, ratings));

        }
    }
}