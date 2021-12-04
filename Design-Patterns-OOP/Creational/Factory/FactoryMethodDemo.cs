using System;
using System.Globalization;

namespace Design_Patterns_OOP.Creational.Factory
{
    public class FactoryMethodDemo
    {
        public static void Show()
        {
            var productsController = new ProductsController();

            productsController.ViewListProductsPage();
        }

        public static void ExShow()
        {
            Schedular scheduler = new GregorianScheduler();
            scheduler.Schedule(new Event());

            Schedular arabianSch = new ArabianScheduler();
            arabianSch.Schedule(new Event());
        }
    }

    public interface ICalendar
    {
        void addEvent(Event eEvent, DateTime date);
    }

    public class GregorianCalendar : ICalendar
    {
        public void addEvent(Event eEvent, DateTime date)
        {
            Out.println("Adding an event on the given date Gregorian Calendar .");
        }
    }

    public class ArabianCalendar : ICalendar
    {
        public void addEvent(Event eEvent, DateTime date)
        {
            Out.println("Adding an event on the given date in Arabian Calendar");
        }
    }

    public class Event
    {
    }

    public abstract class Schedular
    {
        private ICalendar _calendar;

        public Schedular()
        {
            _calendar = CreateCalendar();
        }


        protected virtual ICalendar CreateCalendar()
        {
            return new GregorianCalendar();
        }

        public void Schedule(Event ev)
        {
            _calendar.addEvent(ev, DateTime.Now);
        }
    }

    public class GregorianScheduler : Schedular
    {
        public void schedule(Event eEvent)
        {
            var calendar = CreateCalendar();
            var today = new DateTime();
            calendar.addEvent(eEvent, today);
        }
    }

    public class ArabianScheduler : Schedular
    {
        public void schedule(Event eEvent)
        {
            var calendar = CreateCalendar();
            var today = new DateTime();
            calendar.addEvent(eEvent, today);
        }

        protected override ICalendar CreateCalendar()
        {
            return new ArabianCalendar();
        }
    }
}