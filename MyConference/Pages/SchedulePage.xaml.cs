using MyConference.ViewModels;

namespace MyConference.Pages;

public partial class ScheduleDay1Page : SchedulePage
{
    public int Day { get; set; }
    public ScheduleDay1Page(ScheduleViewModel vm)
	{
		vm.Day = 1;
        Title = "Schedule - Day 1";
        BindingContext = vm;
	}
}

public partial class ScheduleDay2Page : SchedulePage
{
    public int Day { get; set; }
    public ScheduleDay2Page(ScheduleViewModel vm)
    {
        vm.Day = 2;
        Title = "Schedule - Day 2";
        BindingContext = vm;
    }
}

public partial class SchedulePage : ContentPage
{
	ScheduleViewModel vm;
	ScheduleViewModel VM => vm ??= BindingContext as ScheduleViewModel;

    public SchedulePage()
	{
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
        if (VM.Schedule.Count == 0)
        {
            await VM.LoadDataCommand.ExecuteAsync(null);
        }
    }
}