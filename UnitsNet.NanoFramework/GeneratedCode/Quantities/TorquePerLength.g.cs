//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     The magnitude of torque per unit length.
    /// </summary>
    public struct  TorquePerLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TorquePerLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TorquePerLengthUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TorquePerLength(double value, TorquePerLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TorquePerLengthUnit BaseUnit { get; } = TorquePerLengthUnit.NewtonMeterPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TorquePerLength MaxValue { get; } = new TorquePerLength(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TorquePerLength MinValue { get; } = new TorquePerLength(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TorquePerLength Zero { get; } = new TorquePerLength(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceCentimeterPerMeter">KilogramForceCentimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceCentimetersPerMeter property.")]
        public double KilogramForceCentimetersPerMeter => As(TorquePerLengthUnit.KilogramForceCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceMeterPerMeter">KilogramForceMetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceMetersPerMeter property.")]
        public double KilogramForceMetersPerMeter => As(TorquePerLengthUnit.KilogramForceMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceMillimeterPerMeter">KilogramForceMillimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceMillimetersPerMeter property.")]
        public double KilogramForceMillimetersPerMeter => As(TorquePerLengthUnit.KilogramForceMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonCentimeterPerMeter">KilonewtonCentimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonCentimetersPerMeter property.")]
        public double KilonewtonCentimetersPerMeter => As(TorquePerLengthUnit.KilonewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonMeterPerMeter">KilonewtonMetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonMetersPerMeter property.")]
        public double KilonewtonMetersPerMeter => As(TorquePerLengthUnit.KilonewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonMillimeterPerMeter">KilonewtonMillimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonMillimetersPerMeter property.")]
        public double KilonewtonMillimetersPerMeter => As(TorquePerLengthUnit.KilonewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilopoundForceFootPerFoot">KilopoundForceFeetPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundForceFeetPerFoot property.")]
        public double KilopoundForceFeetPerFoot => As(TorquePerLengthUnit.KilopoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilopoundForceInchPerFoot">KilopoundForceInchesPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundForceInchesPerFoot property.")]
        public double KilopoundForceInchesPerFoot => As(TorquePerLengthUnit.KilopoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonCentimeterPerMeter">MeganewtonCentimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonCentimetersPerMeter property.")]
        public double MeganewtonCentimetersPerMeter => As(TorquePerLengthUnit.MeganewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonMeterPerMeter">MeganewtonMetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonMetersPerMeter property.")]
        public double MeganewtonMetersPerMeter => As(TorquePerLengthUnit.MeganewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonMillimeterPerMeter">MeganewtonMillimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonMillimetersPerMeter property.")]
        public double MeganewtonMillimetersPerMeter => As(TorquePerLengthUnit.MeganewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MegapoundForceFootPerFoot">MegapoundForceFeetPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegapoundForceFeetPerFoot property.")]
        public double MegapoundForceFeetPerFoot => As(TorquePerLengthUnit.MegapoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MegapoundForceInchPerFoot">MegapoundForceInchesPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegapoundForceInchesPerFoot property.")]
        public double MegapoundForceInchesPerFoot => As(TorquePerLengthUnit.MegapoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonCentimeterPerMeter">NewtonCentimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonCentimetersPerMeter property.")]
        public double NewtonCentimetersPerMeter => As(TorquePerLengthUnit.NewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonMeterPerMeter">NewtonMetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonMetersPerMeter property.")]
        public double NewtonMetersPerMeter => As(TorquePerLengthUnit.NewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonMillimeterPerMeter">NewtonMillimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonMillimetersPerMeter property.")]
        public double NewtonMillimetersPerMeter => As(TorquePerLengthUnit.NewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.PoundForceFootPerFoot">PoundForceFeetPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundForceFeetPerFoot property.")]
        public double PoundForceFeetPerFoot => As(TorquePerLengthUnit.PoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.PoundForceInchPerFoot">PoundForceInchesPerFoot</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundForceInchesPerFoot property.")]
        public double PoundForceInchesPerFoot => As(TorquePerLengthUnit.PoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceCentimeterPerMeter">TonneForceCentimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceCentimetersPerMeter property.")]
        public double TonneForceCentimetersPerMeter => As(TorquePerLengthUnit.TonneForceCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceMeterPerMeter">TonneForceMetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceMetersPerMeter property.")]
        public double TonneForceMetersPerMeter => As(TorquePerLengthUnit.TonneForceMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceMillimeterPerMeter">TonneForceMillimetersPerMeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceMillimetersPerMeter property.")]
        public double TonneForceMillimetersPerMeter => As(TorquePerLengthUnit.TonneForceMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceCentimeterPerMeter">KilogramForceCentimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilogramForceCentimetersPerMeter => ToUnit(TorquePerLengthUnit.KilogramForceCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceMeterPerMeter">KilogramForceMetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilogramForceMetersPerMeter => ToUnit(TorquePerLengthUnit.KilogramForceMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilogramForceMillimeterPerMeter">KilogramForceMillimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilogramForceMillimetersPerMeter => ToUnit(TorquePerLengthUnit.KilogramForceMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonCentimeterPerMeter">KilonewtonCentimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilonewtonCentimetersPerMeter => ToUnit(TorquePerLengthUnit.KilonewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonMeterPerMeter">KilonewtonMetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilonewtonMetersPerMeter => ToUnit(TorquePerLengthUnit.KilonewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilonewtonMillimeterPerMeter">KilonewtonMillimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToKilonewtonMillimetersPerMeter => ToUnit(TorquePerLengthUnit.KilonewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilopoundForceFootPerFoot">KilopoundForceFeetPerFoot</see>.
        /// </summary>
        public TorquePerLength ToKilopoundForceFeetPerFoot => ToUnit(TorquePerLengthUnit.KilopoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.KilopoundForceInchPerFoot">KilopoundForceInchesPerFoot</see>.
        /// </summary>
        public TorquePerLength ToKilopoundForceInchesPerFoot => ToUnit(TorquePerLengthUnit.KilopoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonCentimeterPerMeter">MeganewtonCentimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToMeganewtonCentimetersPerMeter => ToUnit(TorquePerLengthUnit.MeganewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonMeterPerMeter">MeganewtonMetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToMeganewtonMetersPerMeter => ToUnit(TorquePerLengthUnit.MeganewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MeganewtonMillimeterPerMeter">MeganewtonMillimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToMeganewtonMillimetersPerMeter => ToUnit(TorquePerLengthUnit.MeganewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MegapoundForceFootPerFoot">MegapoundForceFeetPerFoot</see>.
        /// </summary>
        public TorquePerLength ToMegapoundForceFeetPerFoot => ToUnit(TorquePerLengthUnit.MegapoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.MegapoundForceInchPerFoot">MegapoundForceInchesPerFoot</see>.
        /// </summary>
        public TorquePerLength ToMegapoundForceInchesPerFoot => ToUnit(TorquePerLengthUnit.MegapoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonCentimeterPerMeter">NewtonCentimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToNewtonCentimetersPerMeter => ToUnit(TorquePerLengthUnit.NewtonCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonMeterPerMeter">NewtonMetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToNewtonMetersPerMeter => ToUnit(TorquePerLengthUnit.NewtonMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.NewtonMillimeterPerMeter">NewtonMillimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToNewtonMillimetersPerMeter => ToUnit(TorquePerLengthUnit.NewtonMillimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.PoundForceFootPerFoot">PoundForceFeetPerFoot</see>.
        /// </summary>
        public TorquePerLength ToPoundForceFeetPerFoot => ToUnit(TorquePerLengthUnit.PoundForceFootPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.PoundForceInchPerFoot">PoundForceInchesPerFoot</see>.
        /// </summary>
        public TorquePerLength ToPoundForceInchesPerFoot => ToUnit(TorquePerLengthUnit.PoundForceInchPerFoot);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceCentimeterPerMeter">TonneForceCentimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToTonneForceCentimetersPerMeter => ToUnit(TorquePerLengthUnit.TonneForceCentimeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceMeterPerMeter">TonneForceMetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToTonneForceMetersPerMeter => ToUnit(TorquePerLengthUnit.TonneForceMeterPerMeter);

        /// <summary>
        ///     Gets this <see cref="TorquePerLength"/> converted into <see cref="TorquePerLengthUnit.TonneForceMillimeterPerMeter">TonneForceMillimetersPerMeter</see>.
        /// </summary>
        public TorquePerLength ToTonneForceMillimetersPerMeter => ToUnit(TorquePerLengthUnit.TonneForceMillimeterPerMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilogramForceCentimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceCentimetersPerMeter(double kilogramforcecentimeterspermeter) => new TorquePerLength(kilogramforcecentimeterspermeter, TorquePerLengthUnit.KilogramForceCentimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilogramForceMeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceMetersPerMeter(double kilogramforcemeterspermeter) => new TorquePerLength(kilogramforcemeterspermeter, TorquePerLengthUnit.KilogramForceMeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilogramForceMillimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilogramForceMillimetersPerMeter(double kilogramforcemillimeterspermeter) => new TorquePerLength(kilogramforcemillimeterspermeter, TorquePerLengthUnit.KilogramForceMillimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilonewtonCentimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonCentimetersPerMeter(double kilonewtoncentimeterspermeter) => new TorquePerLength(kilonewtoncentimeterspermeter, TorquePerLengthUnit.KilonewtonCentimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilonewtonMeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonMetersPerMeter(double kilonewtonmeterspermeter) => new TorquePerLength(kilonewtonmeterspermeter, TorquePerLengthUnit.KilonewtonMeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilonewtonMillimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilonewtonMillimetersPerMeter(double kilonewtonmillimeterspermeter) => new TorquePerLength(kilonewtonmillimeterspermeter, TorquePerLengthUnit.KilonewtonMillimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilopoundForceFootPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilopoundForceFeetPerFoot(double kilopoundforcefeetperfoot) => new TorquePerLength(kilopoundforcefeetperfoot, TorquePerLengthUnit.KilopoundForceFootPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.KilopoundForceInchPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromKilopoundForceInchesPerFoot(double kilopoundforceinchesperfoot) => new TorquePerLength(kilopoundforceinchesperfoot, TorquePerLengthUnit.KilopoundForceInchPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.MeganewtonCentimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonCentimetersPerMeter(double meganewtoncentimeterspermeter) => new TorquePerLength(meganewtoncentimeterspermeter, TorquePerLengthUnit.MeganewtonCentimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.MeganewtonMeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonMetersPerMeter(double meganewtonmeterspermeter) => new TorquePerLength(meganewtonmeterspermeter, TorquePerLengthUnit.MeganewtonMeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.MeganewtonMillimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMeganewtonMillimetersPerMeter(double meganewtonmillimeterspermeter) => new TorquePerLength(meganewtonmillimeterspermeter, TorquePerLengthUnit.MeganewtonMillimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.MegapoundForceFootPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMegapoundForceFeetPerFoot(double megapoundforcefeetperfoot) => new TorquePerLength(megapoundforcefeetperfoot, TorquePerLengthUnit.MegapoundForceFootPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.MegapoundForceInchPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromMegapoundForceInchesPerFoot(double megapoundforceinchesperfoot) => new TorquePerLength(megapoundforceinchesperfoot, TorquePerLengthUnit.MegapoundForceInchPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.NewtonCentimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonCentimetersPerMeter(double newtoncentimeterspermeter) => new TorquePerLength(newtoncentimeterspermeter, TorquePerLengthUnit.NewtonCentimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.NewtonMeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonMetersPerMeter(double newtonmeterspermeter) => new TorquePerLength(newtonmeterspermeter, TorquePerLengthUnit.NewtonMeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.NewtonMillimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromNewtonMillimetersPerMeter(double newtonmillimeterspermeter) => new TorquePerLength(newtonmillimeterspermeter, TorquePerLengthUnit.NewtonMillimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.PoundForceFootPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromPoundForceFeetPerFoot(double poundforcefeetperfoot) => new TorquePerLength(poundforcefeetperfoot, TorquePerLengthUnit.PoundForceFootPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.PoundForceInchPerFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromPoundForceInchesPerFoot(double poundforceinchesperfoot) => new TorquePerLength(poundforceinchesperfoot, TorquePerLengthUnit.PoundForceInchPerFoot);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.TonneForceCentimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceCentimetersPerMeter(double tonneforcecentimeterspermeter) => new TorquePerLength(tonneforcecentimeterspermeter, TorquePerLengthUnit.TonneForceCentimeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.TonneForceMeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceMetersPerMeter(double tonneforcemeterspermeter) => new TorquePerLength(tonneforcemeterspermeter, TorquePerLengthUnit.TonneForceMeterPerMeter);

        /// <summary>
        ///     Creates a <see cref="TorquePerLength"/> from <see cref="TorquePerLengthUnit.TonneForceMillimeterPerMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TorquePerLength FromTonneForceMillimetersPerMeter(double tonneforcemillimeterspermeter) => new TorquePerLength(tonneforcemillimeterspermeter, TorquePerLengthUnit.TonneForceMillimeterPerMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorquePerLengthUnit" /> to <see cref="TorquePerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TorquePerLength unit value.</returns>
        public static TorquePerLength From(double value, TorquePerLengthUnit fromUnit)
        {
            return new TorquePerLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TorquePerLengthUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TorquePerLength ToUnit(TorquePerLengthUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new TorquePerLength(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            return Unit switch
            {
                TorquePerLengthUnit.KilogramForceCentimeterPerMeter => _value * 0.0980665019960652,
                TorquePerLengthUnit.KilogramForceMeterPerMeter => _value * 9.80665019960652,
                TorquePerLengthUnit.KilogramForceMillimeterPerMeter => _value * 0.00980665019960652,
                TorquePerLengthUnit.KilonewtonCentimeterPerMeter => (_value * 0.01) * 1e3d,
                TorquePerLengthUnit.KilonewtonMeterPerMeter => (_value) * 1e3d,
                TorquePerLengthUnit.KilonewtonMillimeterPerMeter => (_value * 0.001) * 1e3d,
                TorquePerLengthUnit.KilopoundForceFootPerFoot => (_value * 4.44822161526) * 1e3d,
                TorquePerLengthUnit.KilopoundForceInchPerFoot => (_value * 0.370685147638) * 1e3d,
                TorquePerLengthUnit.MeganewtonCentimeterPerMeter => (_value * 0.01) * 1e6d,
                TorquePerLengthUnit.MeganewtonMeterPerMeter => (_value) * 1e6d,
                TorquePerLengthUnit.MeganewtonMillimeterPerMeter => (_value * 0.001) * 1e6d,
                TorquePerLengthUnit.MegapoundForceFootPerFoot => (_value * 4.44822161526) * 1e6d,
                TorquePerLengthUnit.MegapoundForceInchPerFoot => (_value * 0.370685147638) * 1e6d,
                TorquePerLengthUnit.NewtonCentimeterPerMeter => _value * 0.01,
                TorquePerLengthUnit.NewtonMeterPerMeter => _value,
                TorquePerLengthUnit.NewtonMillimeterPerMeter => _value * 0.001,
                TorquePerLengthUnit.PoundForceFootPerFoot => _value * 4.44822161526,
                TorquePerLengthUnit.PoundForceInchPerFoot => _value * 0.370685147638,
                TorquePerLengthUnit.TonneForceCentimeterPerMeter => _value * 98.0665019960652,
                TorquePerLengthUnit.TonneForceMeterPerMeter => _value * 9806.65019960653,
                TorquePerLengthUnit.TonneForceMillimeterPerMeter => _value * 9.80665019960652,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(TorquePerLengthUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TorquePerLengthUnit.KilogramForceCentimeterPerMeter => baseUnitValue * 10.1971619222242,
                TorquePerLengthUnit.KilogramForceMeterPerMeter => baseUnitValue * 0.101971619222242,
                TorquePerLengthUnit.KilogramForceMillimeterPerMeter => baseUnitValue * 101.971619222242,
                TorquePerLengthUnit.KilonewtonCentimeterPerMeter => (baseUnitValue * 100) / 1e3d,
                TorquePerLengthUnit.KilonewtonMeterPerMeter => (baseUnitValue) / 1e3d,
                TorquePerLengthUnit.KilonewtonMillimeterPerMeter => (baseUnitValue * 1000) / 1e3d,
                TorquePerLengthUnit.KilopoundForceFootPerFoot => (baseUnitValue / 4.44822161526) / 1e3d,
                TorquePerLengthUnit.KilopoundForceInchPerFoot => (baseUnitValue / 0.370685147638) / 1e3d,
                TorquePerLengthUnit.MeganewtonCentimeterPerMeter => (baseUnitValue * 100) / 1e6d,
                TorquePerLengthUnit.MeganewtonMeterPerMeter => (baseUnitValue) / 1e6d,
                TorquePerLengthUnit.MeganewtonMillimeterPerMeter => (baseUnitValue * 1000) / 1e6d,
                TorquePerLengthUnit.MegapoundForceFootPerFoot => (baseUnitValue / 4.44822161526) / 1e6d,
                TorquePerLengthUnit.MegapoundForceInchPerFoot => (baseUnitValue / 0.370685147638) / 1e6d,
                TorquePerLengthUnit.NewtonCentimeterPerMeter => baseUnitValue * 100,
                TorquePerLengthUnit.NewtonMeterPerMeter => baseUnitValue,
                TorquePerLengthUnit.NewtonMillimeterPerMeter => baseUnitValue * 1000,
                TorquePerLengthUnit.PoundForceFootPerFoot => baseUnitValue / 4.44822161526,
                TorquePerLengthUnit.PoundForceInchPerFoot => baseUnitValue / 0.370685147638,
                TorquePerLengthUnit.TonneForceCentimeterPerMeter => baseUnitValue * 0.0101971619222242,
                TorquePerLengthUnit.TonneForceMeterPerMeter => baseUnitValue * 0.000101971619222242,
                TorquePerLengthUnit.TonneForceMillimeterPerMeter => baseUnitValue * 0.101971619222242,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

