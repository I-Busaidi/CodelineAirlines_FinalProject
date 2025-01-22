using CodelineAirlines.Models;

namespace CodelineAirlines.Helpers
{
    public class SeatSelectionService
    {
        public List<SeatTemplate> SelectedSeats { get; private set; } = new();

        public void SetSelectedSeats(List<SeatTemplate> seats)
        {
            SelectedSeats = seats;
        }
    }
}
