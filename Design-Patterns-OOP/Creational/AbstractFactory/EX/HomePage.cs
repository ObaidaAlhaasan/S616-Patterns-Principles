namespace Design_Patterns_OOP.Creational.AbstractFactory.EX
{
    public class HomePage
    {
        private IWorkoutPlan workoutPlan;
        private IMealPlan mealPlan;

        public void setGoal(IGoalFactory factory)
        {
            mealPlan = factory.CreateMealPlan();
            workoutPlan = factory.CreateWorkoutPlan();

            Out.println(workoutPlan);
            Out.println(mealPlan);
        }
    }

    public interface IGoalFactory
    {
        IWorkoutPlan CreateWorkoutPlan();
        IMealPlan CreateMealPlan();
    }

    public class BuildMuscleFactory : IGoalFactory
    {
        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new BuildMuscleWorkout();
        }

        public IMealPlan CreateMealPlan()
        {
            return new BuildMuscleMealPlan();
        }
    }

    public class WeightLossFactory : IGoalFactory
    {
        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkout();
        }

        public IMealPlan CreateMealPlan()
        {
            return new WeighLossMealPlan();
        }
    }
}