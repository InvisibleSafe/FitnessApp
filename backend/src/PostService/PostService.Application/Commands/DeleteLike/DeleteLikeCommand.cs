using Shared.Application.Abstractions;

namespace PostService.Application.Commands.DeleteLike;

public record DeleteLikeCommand(Guid Id, Guid UserId) : ICommand;