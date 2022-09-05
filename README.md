# Xamarin.Forms SfRadioButton with MVVM Pattern
This demo sample explains the way to achieve MVVM pattern with Syncfusion Xamarin.Forms RadioButton(SfRadioButton) . Here is the sample code snippet of SfRadioButton in MVVM pattern.

** XAML **

```

<buttons:SfRadioGroup x:Name="radioGroup" BindableLayout.ItemsSource="{Binding Items}">
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <buttons:SfRadioButton x:Name="radioButton" IsChecked="{Binding IsChecked}" Text="{Binding Item}">
                        <buttons:SfRadioButton.Behaviors>
                            <local:EventToCommandBehavior
                                             EventName="StateChanged"
                                             Command="{Binding StateChangedCommand}"
                                             CommandParameter="{x:Reference radioButton}"/>
                        </buttons:SfRadioButton.Behaviors>
                    </buttons:SfRadioButton>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </buttons:SfRadioGroup>
```

** ViewModel **

```

public class ViewModel : INotifyPropertyChanged
{
    
    public List<Model> Items { get; set; }

    public ViewModel()
    {
        Items = new List<Model>()
        {
            new Model(){Item = "C#" , IsChecked = true},
            new Model(){Item = "C++" , IsChecked = false},
            new Model(){Item = "C" , IsChecked = false},
            new Model(){Item = "JAVA" , IsChecked = false},

        };

    }


    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] String propertyName = "")
    {
        if (PropertyChanged != null)
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```
