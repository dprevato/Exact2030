using Model;
using MvvmGen;
using MvvmGen.Events;

namespace Main.ViewModels;

[Inject(typeof(IEventAggregator))]
[ViewModel]
public partial class MainViewModel
{
    // Property
    [Property] private List<Model.Region>? _regions;
    [Property] private string? _regionSelected;
    [Property] private List<Plant>? _plants;
    [Property] private string? _plantSelected;
    [Property] private List<Kind>? _masterKinds;
    [Property] private string? _masterKindSelected;
    [Property] private List<Kind>? _detailKinds;
    [Property] private string? _detailKindSelected;

    [PropertyCallMethod(nameof(GetAppUser))]
    [Property]
    private string? _appUser; // Nome utente collegato

    [PropertyCallMethod(nameof(CurrentCodeBuilder))]
    [Property]
    private string? _currentCode;// codice del Pm attualmente selezionato

    // todo: implementare il sistema di messaggistica

    private string GetAppUser() {
        return "";
    }

    private string? CurrentCodeBuilder() {
        return "";
    }
}
