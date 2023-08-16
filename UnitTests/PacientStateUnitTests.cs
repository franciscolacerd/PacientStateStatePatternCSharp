using FluentAssertions;
using PacientState.Entities;
using PacientState.States;

namespace UnitTests
{
    public class PacientStateUnitTests
    {
        private Pacient _pacient;

        private readonly string _pacientName = "francisco lacerda";

        [SetUp]
        public void Setup()
        {
            this._pacient = new Pacient(this._pacientName, 45);
        }

        [Test]
        public void Should_ChangePacientToTriage_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.CheckIn, this._pacientName));

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.Triage, this._pacientName));
        }

        [Test]
        public void Should_ChangePacientToMedicEvaluation_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.CheckIn, this._pacientName));

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.Triage, this._pacientName));

            /*MedicEvaluation*/
            this._pacient.ChangeState(new MedicEvaluationState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.MedicEvaluation, this._pacientName));
        }

        [Test]
        public void Should_ChangePacientToMedicRelease_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.CheckIn, this._pacientName));

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.Triage, this._pacientName));

            /*MedicEvaluation*/
            this._pacient.ChangeState(new MedicEvaluationState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.MedicEvaluation, this._pacientName));

            /*MedicRelease*/
            this._pacient.ChangeState(new MedicReleaseState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be(string.Format(States.MedicRelease, this._pacientName));
        }
    }
}