﻿using System.Windows.Input;
using Moq;
using NFluent;
using Smartway.UiComponent.Inputs.Barcode;
using Xamarin.Forms;
using Xunit;

namespace Smartway.UiComponent.UnitTests.Inputs.Barcode
{
    public class BarcodeInputBehaviorTest
    {
        public BarcodeInputBehaviorTest()
        {
            Command = new Mock<ICommand>();
            Command.Setup(_ => _.CanExecute(It.IsAny<object>())).Returns(true);
            Behavior = new BarcodeInputBehavior();
            Behavior.Command = Command.Object;
            Entry = new Entry();
            Entry.Behaviors.Add(Behavior);
        }

        public Mock<ICommand> Command { get; set; }

        public Entry Entry { get; set; }

        public BarcodeInputBehavior Behavior { get; set; }
    }

    public class OnTextChanged : BarcodeInputBehaviorTest
    {
        [Fact]
        public void ValidGencodeFilled()
        {
            Entry.Text = "2970812075764";
            
            Check.That(Entry.Text).IsEqualTo("2970812075764");
        }

        [Fact]
        public void GencodeFilledWithNotDigitChar()
        {
            Entry.Text = "x";

            Check.That(Entry.Text).IsEqualTo(null);
        }
    }
}
