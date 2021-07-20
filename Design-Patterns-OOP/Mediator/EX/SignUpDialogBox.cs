using System;

namespace Design_Patterns_OOP.Mediator.EX
{
    public class SignUpDialogBox
    {
        public Checkbox AgreeToTermsCheckBox { get; private set; }
        public TextBox UserNameTextBox { get; private set; }
        public TextBox PasswordTextBox { get; private set; }
        public Button SignUpButton { get; private set; }

        public SignUpDialogBox()
        {
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            AgreeToTermsCheckBox = new Checkbox();
            SignUpButton = new Button();

            UserNameTextBox.AddEventHandler(new UserNameTextBoxEventHandler(IsFormValid, SignUpButton));
            PasswordTextBox.AddEventHandler(new PasswordTextBoxEventHandler(IsFormValid, SignUpButton));
            AgreeToTermsCheckBox.AddEventHandler(new AgreeToTermsCheckBoxEventHandler(IsFormValid, SignUpButton));
        }

        private bool IsFormValid()
        {
            return !UserNameTextBox.IsEmpty && !PasswordTextBox.IsEmpty && AgreeToTermsCheckBox.IsChecked;
        }

        public void SimulateUserInteraction()
        {
            // Initially the button should be disabled
            Console.WriteLine("Initially: " + SignUpButton.IsEnabled);

            // The user enters their username, the button is still disabled
            UserNameTextBox.SetContent("username");
            Console.WriteLine("After setting the username: " + SignUpButton.IsEnabled);

            // The user enters their password, the button is still disabled
            PasswordTextBox.SetContent("password");
            Console.WriteLine("After setting the password: " + SignUpButton.IsEnabled);

            // The agrees to the terms, the button becomes enabled
            AgreeToTermsCheckBox.SetChecked(true);
            Console.WriteLine("After agreeing to terms: " + SignUpButton.IsEnabled);

            // The user removes the password, the button becomes disabled
            PasswordTextBox.SetContent("");
            Console.WriteLine("After removing the password: " + SignUpButton.IsEnabled);

            // The user enters the password again, the button becomes enabled
            PasswordTextBox.SetContent("password");
            Console.WriteLine("After re-setting the password: " + SignUpButton.IsEnabled);
        }
    }

    public class AgreeToTermsCheckBoxEventHandler : EventHandler
    {
        public Func<bool> IsFormValid { get; }
        public Button SignUpButton { get; }

        public AgreeToTermsCheckBoxEventHandler(Func<bool> isFormValid, Button signUpButton)
        {
            IsFormValid = isFormValid;
            SignUpButton = signUpButton;
        }

        public override void Handle()
        {
            SignUpButton.SetIsEnabled(IsFormValid());
        }
    }

    public class PasswordTextBoxEventHandler : EventHandler
    {
        public Func<bool> IsFormValid { get; }
        public Button SignUpButton { get; }

        public PasswordTextBoxEventHandler(Func<bool> isFormValid, Button signUpButton)
        {
            IsFormValid = isFormValid;
            SignUpButton = signUpButton;
        }

        public override void Handle()
        {
            SignUpButton.SetIsEnabled(IsFormValid());
        }
    }

    public class UserNameTextBoxEventHandler : EventHandler

    {
        public Func<bool> IsFormValid { get; }
        public Button SignUpButton { get; }

        public UserNameTextBoxEventHandler(Func<bool> isFormValid, Button signUpButton)
        {
            IsFormValid = isFormValid;
            SignUpButton = signUpButton;
        }

        public override void Handle()
        {
            SignUpButton.SetIsEnabled(IsFormValid());
        }
    }
}