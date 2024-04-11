﻿namespace Blogger.Application.Usecases.MakeDraft;

public record MakeDraftCommand(string title, string body, string summery, string[] Tags)
    : IRequest<MakeDraftCommandResponse>;