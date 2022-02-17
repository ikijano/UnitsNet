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
    ///     Torque, moment or moment of force (see the terminology below), is the tendency of a force to rotate an object about an axis,[1] fulcrum, or pivot. Just as a force is a push or a pull, a torque can be thought of as a twist to an object. Mathematically, torque is defined as the cross product of the lever-arm distance and force, which tends to produce rotation. Loosely speaking, torque is a measure of the turning force on an object such as a bolt or a flywheel. For example, pushing or pulling the handle of a wrench connected to a nut or bolt produces a torque (turning force) that loosens or tightens the nut or bolt.
    /// </summary>
    public struct  Torque
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TorqueUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TorqueUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Torque(double value, TorqueUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TorqueUnit BaseUnit { get; } = TorqueUnit.NewtonMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Torque MaxValue { get; } = new Torque(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Torque MinValue { get; } = new Torque(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Torque Zero { get; } = new Torque(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToGramForceCentimeters property.")]
        public double GramForceCentimeters => As(TorqueUnit.GramForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToGramForceMeters property.")]
        public double GramForceMeters => As(TorqueUnit.GramForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToGramForceMillimeters property.")]
        public double GramForceMillimeters => As(TorqueUnit.GramForceMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceCentimeters property.")]
        public double KilogramForceCentimeters => As(TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceMeters property.")]
        public double KilogramForceMeters => As(TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilogramForceMillimeters property.")]
        public double KilogramForceMillimeters => As(TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonCentimeters property.")]
        public double KilonewtonCentimeters => As(TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonMeters property.")]
        public double KilonewtonMeters => As(TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilonewtonMillimeters property.")]
        public double KilonewtonMillimeters => As(TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilopoundForceFoot"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundForceFeet property.")]
        public double KilopoundForceFeet => As(TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilopoundForceInch"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopoundForceInches property.")]
        public double KilopoundForceInches => As(TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonCentimeters property.")]
        public double MeganewtonCentimeters => As(TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonMeters property.")]
        public double MeganewtonMeters => As(TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMeganewtonMillimeters property.")]
        public double MeganewtonMillimeters => As(TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MegapoundForceFoot"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegapoundForceFeet property.")]
        public double MegapoundForceFeet => As(TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MegapoundForceInch"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegapoundForceInches property.")]
        public double MegapoundForceInches => As(TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonCentimeters property.")]
        public double NewtonCentimeters => As(TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonMeters property.")]
        public double NewtonMeters => As(TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNewtonMillimeters property.")]
        public double NewtonMillimeters => As(TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundalFoot"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundalFeet property.")]
        public double PoundalFeet => As(TorqueUnit.PoundalFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundForceFoot"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundForceFeet property.")]
        public double PoundForceFeet => As(TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundForceInch"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPoundForceInches property.")]
        public double PoundForceInches => As(TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceCentimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceCentimeters property.")]
        public double TonneForceCentimeters => As(TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceMeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceMeters property.")]
        public double TonneForceMeters => As(TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceMillimeter"/> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonneForceMillimeters property.")]
        public double TonneForceMillimeters => As(TorqueUnit.TonneForceMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceCentimeter"/>.
        /// </summary>
        public Torque ToGramForceCentimeters => ToUnit(TorqueUnit.GramForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceMeter"/>.
        /// </summary>
        public Torque ToGramForceMeters => ToUnit(TorqueUnit.GramForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.GramForceMillimeter"/>.
        /// </summary>
        public Torque ToGramForceMillimeters => ToUnit(TorqueUnit.GramForceMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceCentimeter"/>.
        /// </summary>
        public Torque ToKilogramForceCentimeters => ToUnit(TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceMeter"/>.
        /// </summary>
        public Torque ToKilogramForceMeters => ToUnit(TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilogramForceMillimeter"/>.
        /// </summary>
        public Torque ToKilogramForceMillimeters => ToUnit(TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonCentimeter"/>.
        /// </summary>
        public Torque ToKilonewtonCentimeters => ToUnit(TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonMeter"/>.
        /// </summary>
        public Torque ToKilonewtonMeters => ToUnit(TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilonewtonMillimeter"/>.
        /// </summary>
        public Torque ToKilonewtonMillimeters => ToUnit(TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilopoundForceFoot"/>.
        /// </summary>
        public Torque ToKilopoundForceFeet => ToUnit(TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.KilopoundForceInch"/>.
        /// </summary>
        public Torque ToKilopoundForceInches => ToUnit(TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonCentimeter"/>.
        /// </summary>
        public Torque ToMeganewtonCentimeters => ToUnit(TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonMeter"/>.
        /// </summary>
        public Torque ToMeganewtonMeters => ToUnit(TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MeganewtonMillimeter"/>.
        /// </summary>
        public Torque ToMeganewtonMillimeters => ToUnit(TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MegapoundForceFoot"/>.
        /// </summary>
        public Torque ToMegapoundForceFeet => ToUnit(TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.MegapoundForceInch"/>.
        /// </summary>
        public Torque ToMegapoundForceInches => ToUnit(TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonCentimeter"/>.
        /// </summary>
        public Torque ToNewtonCentimeters => ToUnit(TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonMeter"/>.
        /// </summary>
        public Torque ToNewtonMeters => ToUnit(TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.NewtonMillimeter"/>.
        /// </summary>
        public Torque ToNewtonMillimeters => ToUnit(TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundalFoot"/>.
        /// </summary>
        public Torque ToPoundalFeet => ToUnit(TorqueUnit.PoundalFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundForceFoot"/>.
        /// </summary>
        public Torque ToPoundForceFeet => ToUnit(TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.PoundForceInch"/>.
        /// </summary>
        public Torque ToPoundForceInches => ToUnit(TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceCentimeter"/>.
        /// </summary>
        public Torque ToTonneForceCentimeters => ToUnit(TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceMeter"/>.
        /// </summary>
        public Torque ToTonneForceMeters => ToUnit(TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Gets this <see cref="Torque"/> converted into <see cref="TorqueUnit.TonneForceMillimeter"/>.
        /// </summary>
        public Torque ToTonneForceMillimeters => ToUnit(TorqueUnit.TonneForceMillimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.GramForceCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromGramForceCentimeters(double gramforcecentimeters) => new Torque(gramforcecentimeters, TorqueUnit.GramForceCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.GramForceMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromGramForceMeters(double gramforcemeters) => new Torque(gramforcemeters, TorqueUnit.GramForceMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.GramForceMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromGramForceMillimeters(double gramforcemillimeters) => new Torque(gramforcemillimeters, TorqueUnit.GramForceMillimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilogramForceCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceCentimeters(double kilogramforcecentimeters) => new Torque(kilogramforcecentimeters, TorqueUnit.KilogramForceCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilogramForceMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMeters(double kilogramforcemeters) => new Torque(kilogramforcemeters, TorqueUnit.KilogramForceMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilogramForceMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilogramForceMillimeters(double kilogramforcemillimeters) => new Torque(kilogramforcemillimeters, TorqueUnit.KilogramForceMillimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilonewtonCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonCentimeters(double kilonewtoncentimeters) => new Torque(kilonewtoncentimeters, TorqueUnit.KilonewtonCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilonewtonMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMeters(double kilonewtonmeters) => new Torque(kilonewtonmeters, TorqueUnit.KilonewtonMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilonewtonMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilonewtonMillimeters(double kilonewtonmillimeters) => new Torque(kilonewtonmillimeters, TorqueUnit.KilonewtonMillimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilopoundForceFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceFeet(double kilopoundforcefeet) => new Torque(kilopoundforcefeet, TorqueUnit.KilopoundForceFoot);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.KilopoundForceInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromKilopoundForceInches(double kilopoundforceinches) => new Torque(kilopoundforceinches, TorqueUnit.KilopoundForceInch);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.MeganewtonCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonCentimeters(double meganewtoncentimeters) => new Torque(meganewtoncentimeters, TorqueUnit.MeganewtonCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.MeganewtonMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMeters(double meganewtonmeters) => new Torque(meganewtonmeters, TorqueUnit.MeganewtonMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.MeganewtonMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMeganewtonMillimeters(double meganewtonmillimeters) => new Torque(meganewtonmillimeters, TorqueUnit.MeganewtonMillimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.MegapoundForceFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceFeet(double megapoundforcefeet) => new Torque(megapoundforcefeet, TorqueUnit.MegapoundForceFoot);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.MegapoundForceInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromMegapoundForceInches(double megapoundforceinches) => new Torque(megapoundforceinches, TorqueUnit.MegapoundForceInch);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.NewtonCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonCentimeters(double newtoncentimeters) => new Torque(newtoncentimeters, TorqueUnit.NewtonCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.NewtonMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMeters(double newtonmeters) => new Torque(newtonmeters, TorqueUnit.NewtonMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.NewtonMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromNewtonMillimeters(double newtonmillimeters) => new Torque(newtonmillimeters, TorqueUnit.NewtonMillimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.PoundalFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundalFeet(double poundalfeet) => new Torque(poundalfeet, TorqueUnit.PoundalFoot);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.PoundForceFoot"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceFeet(double poundforcefeet) => new Torque(poundforcefeet, TorqueUnit.PoundForceFoot);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.PoundForceInch"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromPoundForceInches(double poundforceinches) => new Torque(poundforceinches, TorqueUnit.PoundForceInch);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.TonneForceCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceCentimeters(double tonneforcecentimeters) => new Torque(tonneforcecentimeters, TorqueUnit.TonneForceCentimeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.TonneForceMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMeters(double tonneforcemeters) => new Torque(tonneforcemeters, TorqueUnit.TonneForceMeter);

        /// <summary>
        ///     Creates a <see cref="Torque"/> from <see cref="TorqueUnit.TonneForceMillimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Torque FromTonneForceMillimeters(double tonneforcemillimeters) => new Torque(tonneforcemillimeters, TorqueUnit.TonneForceMillimeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorqueUnit" /> to <see cref="Torque" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Torque unit value.</returns>
        public static Torque From(double value, TorqueUnit fromUnit)
        {
            return new Torque(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TorqueUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Torque ToUnit(TorqueUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Torque(convertedValue, unit);
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
                TorqueUnit.GramForceCentimeter => _value * 9.80665e-5,
                TorqueUnit.GramForceMeter => _value * 9.80665e-3,
                TorqueUnit.GramForceMillimeter => _value * 9.80665e-6,
                TorqueUnit.KilogramForceCentimeter => _value * 9.80665e-2,
                TorqueUnit.KilogramForceMeter => _value * 9.80665,
                TorqueUnit.KilogramForceMillimeter => _value * 9.80665e-3,
                TorqueUnit.KilonewtonCentimeter => (_value * 0.01) * 1e3d,
                TorqueUnit.KilonewtonMeter => (_value) * 1e3d,
                TorqueUnit.KilonewtonMillimeter => (_value * 0.001) * 1e3d,
                TorqueUnit.KilopoundForceFoot => (_value * 1.3558179483314) * 1e3d,
                TorqueUnit.KilopoundForceInch => (_value * 1.129848290276167e-1) * 1e3d,
                TorqueUnit.MeganewtonCentimeter => (_value * 0.01) * 1e6d,
                TorqueUnit.MeganewtonMeter => (_value) * 1e6d,
                TorqueUnit.MeganewtonMillimeter => (_value * 0.001) * 1e6d,
                TorqueUnit.MegapoundForceFoot => (_value * 1.3558179483314) * 1e6d,
                TorqueUnit.MegapoundForceInch => (_value * 1.129848290276167e-1) * 1e6d,
                TorqueUnit.NewtonCentimeter => _value * 0.01,
                TorqueUnit.NewtonMeter => _value,
                TorqueUnit.NewtonMillimeter => _value * 0.001,
                TorqueUnit.PoundalFoot => _value * 4.21401100938048e-2,
                TorqueUnit.PoundForceFoot => _value * 1.3558179483314,
                TorqueUnit.PoundForceInch => _value * 1.129848290276167e-1,
                TorqueUnit.TonneForceCentimeter => _value * 9.80665e1,
                TorqueUnit.TonneForceMeter => _value * 9.80665e3,
                TorqueUnit.TonneForceMillimeter => _value * 9.80665,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(TorqueUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TorqueUnit.GramForceCentimeter => baseUnitValue / 9.80665e-5,
                TorqueUnit.GramForceMeter => baseUnitValue / 9.80665e-3,
                TorqueUnit.GramForceMillimeter => baseUnitValue / 9.80665e-6,
                TorqueUnit.KilogramForceCentimeter => baseUnitValue / 9.80665e-2,
                TorqueUnit.KilogramForceMeter => baseUnitValue / 9.80665,
                TorqueUnit.KilogramForceMillimeter => baseUnitValue / 9.80665e-3,
                TorqueUnit.KilonewtonCentimeter => (baseUnitValue * 100) / 1e3d,
                TorqueUnit.KilonewtonMeter => (baseUnitValue) / 1e3d,
                TorqueUnit.KilonewtonMillimeter => (baseUnitValue * 1000) / 1e3d,
                TorqueUnit.KilopoundForceFoot => (baseUnitValue / 1.3558179483314) / 1e3d,
                TorqueUnit.KilopoundForceInch => (baseUnitValue / 1.129848290276167e-1) / 1e3d,
                TorqueUnit.MeganewtonCentimeter => (baseUnitValue * 100) / 1e6d,
                TorqueUnit.MeganewtonMeter => (baseUnitValue) / 1e6d,
                TorqueUnit.MeganewtonMillimeter => (baseUnitValue * 1000) / 1e6d,
                TorqueUnit.MegapoundForceFoot => (baseUnitValue / 1.3558179483314) / 1e6d,
                TorqueUnit.MegapoundForceInch => (baseUnitValue / 1.129848290276167e-1) / 1e6d,
                TorqueUnit.NewtonCentimeter => baseUnitValue * 100,
                TorqueUnit.NewtonMeter => baseUnitValue,
                TorqueUnit.NewtonMillimeter => baseUnitValue * 1000,
                TorqueUnit.PoundalFoot => baseUnitValue / 4.21401100938048e-2,
                TorqueUnit.PoundForceFoot => baseUnitValue / 1.3558179483314,
                TorqueUnit.PoundForceInch => baseUnitValue / 1.129848290276167e-1,
                TorqueUnit.TonneForceCentimeter => baseUnitValue / 9.80665e1,
                TorqueUnit.TonneForceMeter => baseUnitValue / 9.80665e3,
                TorqueUnit.TonneForceMillimeter => baseUnitValue / 9.80665,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

