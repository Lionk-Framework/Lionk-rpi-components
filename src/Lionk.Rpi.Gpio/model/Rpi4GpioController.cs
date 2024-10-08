﻿// Copyright © 2024 Lionk Project

using System.Device.Gpio;

namespace Lionk.Rpi.Gpio;

/// <summary>
/// This class represents a GPIO controller.
/// </summary>
public class Rpi4GpioController : BaseGpioController
{
    #region Private Fields

    private readonly GpioController _controller;

    #endregion Private Fields

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="Rpi4GpioController"/> class.
    /// </summary>
    public Rpi4GpioController() => _controller = new GpioController();

    #endregion Public Constructors

    #region Public Methods

    /// <summary>
    /// Method to close a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to open. </param>
    public override void ClosePin(int pinNumber) => _controller.ClosePin(pinNumber);

    /// <inheritdoc/>
    public override void Dispose() => _controller.Dispose();

    /// <summary>
    /// Method to get the mode of a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to get the mode. </param>
    /// <returns> The mode of the pin. </returns>
    public override PinMode GetPinMode(int pinNumber) => _controller.GetPinMode(pinNumber);

    /// <summary>
    /// Method to check if a pin mode is supported.
    /// </summary>
    /// <param name="pinNumber"> The pin number to check. </param>
    /// <param name="mode"> The mode to check. </param>
    /// <returns> True if the mode is supported, false otherwise. </returns>
    public override bool IsPinModeSupported(int pinNumber, PinMode mode) => _controller.IsPinModeSupported(pinNumber, mode);

    /// <summary>
    /// Method to check if a pin is open.
    /// </summary>
    /// <param name="pinNumber"> The pin number to check. </param>
    /// <returns> True if the pin is open, false otherwise. </returns>
    public override bool IsPinOpen(int pinNumber) => _controller.IsPinOpen(pinNumber);

    /// <summary>
    /// Method to open a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to open. </param>
    public override void OpenPin(int pinNumber) => _controller.OpenPin(pinNumber);

    /// <summary>
    /// Method to open a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to open. </param>
    /// <param name="mode"> The mode of the pin. </param>
    public override void OpenPin(int pinNumber, PinMode mode) => _controller.OpenPin(pinNumber, mode);

    /// <summary>
    /// Method to read the value of a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to read. </param>
    /// <returns> The value of the pin. </returns>
    public override PinValue Read(int pinNumber) => _controller.Read(pinNumber);

    /// <summary>
    /// Method to register a callback for pin value changed event.
    /// </summary>
    /// <param name="pin"> The pin to register. </param>
    /// <param name="eventTypes"> The event types to register. </param>
    public override void RegisterCallbackForPinValueChangedEvent(Rpi4Gpio pin, PinEventTypes eventTypes)
        => _controller.RegisterCallbackForPinValueChangedEvent((int)pin, eventTypes, OnPinValueChanged);

    /// <summary>
    /// Method to set the mode of a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to set the mode. </param>
    /// <param name="mode"> The mode to set. </param>
    public override void SetPinMode(int pinNumber, PinMode mode) => _controller.SetPinMode(pinNumber, mode);

    /// <summary>
    /// Method to toggle a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to toggle. </param>
    public override void Toggle(int pinNumber) => _controller.Toggle(pinNumber);

    /// <summary>
    /// Method to write a value to a pin.
    /// </summary>
    /// <param name="pinNumber"> The pin number to write. </param>
    /// <param name="value"> The value to write. </param>
    public override void Write(int pinNumber, PinValue value) => _controller.Write(pinNumber, value);

    #endregion Public Methods
}
