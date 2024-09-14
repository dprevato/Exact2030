using Main.Abstractions;
using Main.Events;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model;
using MvvmGen;
using MvvmGen.Events;

namespace Main.ViewModels;

[Inject(typeof(IEventAggregator))]
[Inject(typeof(IApplicationUser))]
[ViewModel]
public partial class MainViewModel : IEventSubscriber<StatusCurrentPmCode>, IEventSubscriber<StatusMessageEvent>
{
    protected static System.Windows.Forms.Timer MsgTimer = new() { Interval = 5000 };
    #region Implementation of IEventSubscriber<StatusCurrentPmCode>

    public void OnEvent(StatusCurrentPmCode eventData) => ShowCurrentCode(eventData);
    public void OnEvent(StatusMessageEvent eventData) => ShowMessage(eventData);

    #endregion

    partial void OnInitialize() {
        GetAppUserName();
        CurrentCodeBuilder();
        MsgTimer.Tick += TimerEventProcessor;
        Test();
    }

    // Property
    [Property] private List<Model.Region>? _regions;

    [PropertyCallMethod(nameof(CurrentCodeBuilder))]
    [Property] private string? _regionSelected;

    [Property] private List<Plant>? _plants;

    [PropertyCallMethod(nameof(CurrentCodeBuilder))]
    [Property] private string? _plantSelected;

    [Property] private List<Kind>? _masterKinds;

    [Property] private string? _masterKindSelected;

    [Property] private List<Kind>? _detailKinds;

    [PropertyCallMethod(nameof(CurrentCodeBuilder))]
    [Property] private string? _detailKindSelected;

    [Property] private string? _operatorBoxTooltip = "Utente attualmente collegato";

    [Property] private string? _InfoBoxTooltip = "Messaggi e avvisi per l'operatore";

    [Property] private string? _codeBoxTooltip = "Codice corrente";

    [Property]
    private string? _appUserName; // Nome utente collegato - viene aggiornato soltanto una volta all'apertura dell'applicazione

    [Property]
    private string? _currentCode;// codice del Pm attualmente selezionato

    [Property] private bool? _boldMessage;

    // todo: implementare il sistema di messaggistica
    [Property] private Image _infoImage;
    [Property] private string? _infoMessage;

    [Command]
    private void Test() {
        EventAggregator.Publish(new StatusMessageEvent(new Bitmap("..\\..\\..\\Resources\\button-error.png"), "Messaggio per l'operatore"));
    }

    private void ShowMessage(StatusMessageEvent e) {
        // ShowMessage riceve eventData da OnEvent. Viene eseguito ogni volta che un nuovo evento StatusMessageEvent viene evocato.
        // ShowMessage viene lanciata perchè in quelche punto dell'applicazione è stato pubblicato un messaggio da visualizzare. Non
        // è pervisto che venga pubblicato un messaggio vuoto.

        // todo: assegnare all'intervallo la quantità che risulta dalle preferenze dell'utente
        InfoImage = e.msgIcon!;
        InfoMessage = e.msgText;
        MsgTimer.Start();
    }

    private void ShowCurrentCode(StatusCurrentPmCode e) {
        CurrentCode = e.currentCode;
    }

    private void TimerEventProcessor(object? sender, EventArgs e) {
        MsgTimer.Stop();
        EventAggregator.Publish(new StatusMessageEvent(new Bitmap("..\\..\\..\\Resources\\button-info.png"), string.Empty));
    }

    private void GetAppUserName() => AppUserName = ApplicationUser.GetUser().LoginName;

    private void CurrentCodeBuilder() {
        CurrentCode = $"{RegionSelected}.{PlantSelected}.{DetailKindSelected}";
        EventAggregator.Publish(new StatusCurrentPmCode(CurrentCode));
    }
}
