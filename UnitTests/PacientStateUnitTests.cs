using FluentAssertions;
using PacientState.Entities;
using PacientState.States;

namespace UnitTests
{
    public class PacientStateUnitTests
    {
        private Pacient _pacient;

        [SetUp]
        public void Setup()
        {
            this._pacient = new Pacient("francisco lacerda", 45);
        }

        [Test]
        public void Should_ChangePacientToTriage_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing checkin to pacient francisco lacerda");

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing triage to pacient francisco lacerda");
        }

        [Test]
        public void Should_ChangePacientToMedicEvaluation_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing checkin to pacient francisco lacerda");

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing triage to pacient francisco lacerda");

            /*MedicEvaluation*/
            this._pacient.ChangeState(new MedicEvaluationState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing medic evaluation to pacient francisco lacerda");
        }

        [Test]
        public void Should_ChangePacientToMedicRelease_ReturnState()
        {
            /*CheckIn*/
            // Arrange

            // Act
            var state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing checkin to pacient francisco lacerda");

            /*Triage*/
            // Arrange
            this._pacient.ChangeState(new TriageState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing triage to pacient francisco lacerda");

            /*MedicEvaluation*/
            this._pacient.ChangeState(new MedicEvaluationState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing medic evaluation to pacient francisco lacerda");

            /*MedicRelease*/
            this._pacient.ChangeState(new MedicReleaseState());

            // Act
            state = this._pacient.GetCurrentState();

            // Assert
            state.Should().Be("Doing medic release to pacient francisco lacerda");
        }
    }
}