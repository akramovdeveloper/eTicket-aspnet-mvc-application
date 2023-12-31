﻿using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Application.eTicket.MVC.UseCases.Cinemas.Commands.CreateCinema;
public class CreateCinemaCommandValidator : AbstractValidator<CreateCinemaCommand>
{
    public CreateCinemaCommandValidator()
    {
        RuleFor(command => command.CinemaName)
            .NotEmpty().WithMessage("Cinema name is required.")
            .MaximumLength(100).WithMessage("Cinema name must not exceed 100 characters.");

        RuleFor(command => command.CinemaDescription)
            .NotEmpty().WithMessage("Cinema description is required.")
            .MaximumLength(500).WithMessage("Cinema description must not exceed 500 characters.");

        RuleFor(command => command.CinemaLogo)
            .Must(BeAValidImage).WithMessage("Invalid image format. Only JPG, PNG, and JPEG formats are allowed.")
            .Must(BeAValidImageSize).WithMessage("Image size must not exceed 5MB.");

        RuleFor(command => command.CinemaLocation)
            .NotEmpty().WithMessage("Cinema location is required.");
    }

    private bool BeAValidImage(IFormFile filePath)
    {
        if (string.IsNullOrEmpty(filePath.FileName))
            return false;

        var allowedFormats = new[] { ".jpg", ".jpeg", ".png" };
        var ext = Path.GetExtension(filePath.FileName);
        return allowedFormats.Contains(ext, StringComparer.OrdinalIgnoreCase);
    }

    private bool BeAValidImageSize(IFormFile filePath)
    {
        if (string.IsNullOrEmpty(filePath.FileName))
            return false;

        const int maxSize = 5 * 1024 * 1024; // 5MB
        var fileInfo = new FileInfo(filePath.FileName);
        return fileInfo.Length <= maxSize;
    }
}
