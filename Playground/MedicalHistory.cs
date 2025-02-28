namespace Playground;

public class MedicalHistory
{
    private string _patientName;
    private DateTime _date;

    public MedicalHistory(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public void Reschedule(DateTime newDate)
    {
        _date = newDate;
    }

    public void Reschedule(int days, int month)
    {
        _date = new DateTime(_date.Year, month, days);
    }
}