using CodelineAirlines.DTOs.AirplaneDTOs;
using CodelineAirlines.DTOs.PassengerDTOs;
namespace CodelineAirlines.Helpers
{
    public class AppState
    {
        public List<PassengerInputDTOs> PassengersInput { get; set; } = new();

        public List<SeatsOutputDTO> SelectedSeats {  get; set; } = new();


        public event Action? OnChange;

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
