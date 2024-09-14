namespace Main.Events;

public record StatusMessageEvent(Image? msgIcon, string? msgText);

public record StatusCurrentPmCode(string? currentCode);