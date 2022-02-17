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
    ///     Electrical resistivity (also known as resistivity, specific electrical resistance, or volume resistivity) is a fundamental property that quantifies how strongly a given material opposes the flow of electric current.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electrical_resistivity_and_conductivity
    /// </remarks>
    public struct  ElectricResistivity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricResistivityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricResistivityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ElectricResistivity(double value, ElectricResistivityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricResistivityUnit BaseUnit { get; } = ElectricResistivityUnit.OhmMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ElectricResistivity MaxValue { get; } = new ElectricResistivity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ElectricResistivity MinValue { get; } = new ElectricResistivity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricResistivity Zero { get; } = new ElectricResistivity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.KiloohmCentimeter">KiloohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKiloohmsCentimeter property.")]
        public double KiloohmsCentimeter => As(ElectricResistivityUnit.KiloohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.KiloohmMeter">KiloohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKiloohmMeters property.")]
        public double KiloohmMeters => As(ElectricResistivityUnit.KiloohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MegaohmCentimeter">MegaohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegaohmsCentimeter property.")]
        public double MegaohmsCentimeter => As(ElectricResistivityUnit.MegaohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MegaohmMeter">MegaohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegaohmMeters property.")]
        public double MegaohmMeters => As(ElectricResistivityUnit.MegaohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MicroohmCentimeter">MicroohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMicroohmsCentimeter property.")]
        public double MicroohmsCentimeter => As(ElectricResistivityUnit.MicroohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MicroohmMeter">MicroohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMicroohmMeters property.")]
        public double MicroohmMeters => As(ElectricResistivityUnit.MicroohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MilliohmCentimeter">MilliohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMilliohmsCentimeter property.")]
        public double MilliohmsCentimeter => As(ElectricResistivityUnit.MilliohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MilliohmMeter">MilliohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMilliohmMeters property.")]
        public double MilliohmMeters => As(ElectricResistivityUnit.MilliohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.NanoohmCentimeter">NanoohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNanoohmsCentimeter property.")]
        public double NanoohmsCentimeter => As(ElectricResistivityUnit.NanoohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.NanoohmMeter">NanoohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNanoohmMeters property.")]
        public double NanoohmMeters => As(ElectricResistivityUnit.NanoohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.OhmCentimeter">OhmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToOhmsCentimeter property.")]
        public double OhmsCentimeter => As(ElectricResistivityUnit.OhmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.OhmMeter">OhmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToOhmMeters property.")]
        public double OhmMeters => As(ElectricResistivityUnit.OhmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.PicoohmCentimeter">PicoohmsCentimeter</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPicoohmsCentimeter property.")]
        public double PicoohmsCentimeter => As(ElectricResistivityUnit.PicoohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.PicoohmMeter">PicoohmMeters</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPicoohmMeters property.")]
        public double PicoohmMeters => As(ElectricResistivityUnit.PicoohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.KiloohmCentimeter">KiloohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToKiloohmsCentimeter => ToUnit(ElectricResistivityUnit.KiloohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.KiloohmMeter">KiloohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToKiloohmMeters => ToUnit(ElectricResistivityUnit.KiloohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MegaohmCentimeter">MegaohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToMegaohmsCentimeter => ToUnit(ElectricResistivityUnit.MegaohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MegaohmMeter">MegaohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToMegaohmMeters => ToUnit(ElectricResistivityUnit.MegaohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MicroohmCentimeter">MicroohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToMicroohmsCentimeter => ToUnit(ElectricResistivityUnit.MicroohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MicroohmMeter">MicroohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToMicroohmMeters => ToUnit(ElectricResistivityUnit.MicroohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MilliohmCentimeter">MilliohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToMilliohmsCentimeter => ToUnit(ElectricResistivityUnit.MilliohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.MilliohmMeter">MilliohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToMilliohmMeters => ToUnit(ElectricResistivityUnit.MilliohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.NanoohmCentimeter">NanoohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToNanoohmsCentimeter => ToUnit(ElectricResistivityUnit.NanoohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.NanoohmMeter">NanoohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToNanoohmMeters => ToUnit(ElectricResistivityUnit.NanoohmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.OhmCentimeter">OhmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToOhmsCentimeter => ToUnit(ElectricResistivityUnit.OhmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.OhmMeter">OhmMeters</see>.
        /// </summary>
        public ElectricResistivity ToOhmMeters => ToUnit(ElectricResistivityUnit.OhmMeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.PicoohmCentimeter">PicoohmsCentimeter</see>.
        /// </summary>
        public ElectricResistivity ToPicoohmsCentimeter => ToUnit(ElectricResistivityUnit.PicoohmCentimeter);

        /// <summary>
        ///     Gets this <see cref="ElectricResistivity"/> converted into <see cref="ElectricResistivityUnit.PicoohmMeter">PicoohmMeters</see>.
        /// </summary>
        public ElectricResistivity ToPicoohmMeters => ToUnit(ElectricResistivityUnit.PicoohmMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.KiloohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromKiloohmsCentimeter(double kiloohmscentimeter) => new ElectricResistivity(kiloohmscentimeter, ElectricResistivityUnit.KiloohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.KiloohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromKiloohmMeters(double kiloohmmeters) => new ElectricResistivity(kiloohmmeters, ElectricResistivityUnit.KiloohmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MegaohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMegaohmsCentimeter(double megaohmscentimeter) => new ElectricResistivity(megaohmscentimeter, ElectricResistivityUnit.MegaohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MegaohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMegaohmMeters(double megaohmmeters) => new ElectricResistivity(megaohmmeters, ElectricResistivityUnit.MegaohmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MicroohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMicroohmsCentimeter(double microohmscentimeter) => new ElectricResistivity(microohmscentimeter, ElectricResistivityUnit.MicroohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MicroohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMicroohmMeters(double microohmmeters) => new ElectricResistivity(microohmmeters, ElectricResistivityUnit.MicroohmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MilliohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMilliohmsCentimeter(double milliohmscentimeter) => new ElectricResistivity(milliohmscentimeter, ElectricResistivityUnit.MilliohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.MilliohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromMilliohmMeters(double milliohmmeters) => new ElectricResistivity(milliohmmeters, ElectricResistivityUnit.MilliohmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.NanoohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromNanoohmsCentimeter(double nanoohmscentimeter) => new ElectricResistivity(nanoohmscentimeter, ElectricResistivityUnit.NanoohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.NanoohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromNanoohmMeters(double nanoohmmeters) => new ElectricResistivity(nanoohmmeters, ElectricResistivityUnit.NanoohmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.OhmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromOhmsCentimeter(double ohmscentimeter) => new ElectricResistivity(ohmscentimeter, ElectricResistivityUnit.OhmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.OhmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromOhmMeters(double ohmmeters) => new ElectricResistivity(ohmmeters, ElectricResistivityUnit.OhmMeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.PicoohmCentimeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromPicoohmsCentimeter(double picoohmscentimeter) => new ElectricResistivity(picoohmscentimeter, ElectricResistivityUnit.PicoohmCentimeter);

        /// <summary>
        ///     Creates a <see cref="ElectricResistivity"/> from <see cref="ElectricResistivityUnit.PicoohmMeter"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistivity FromPicoohmMeters(double picoohmmeters) => new ElectricResistivity(picoohmmeters, ElectricResistivityUnit.PicoohmMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricResistivityUnit" /> to <see cref="ElectricResistivity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricResistivity unit value.</returns>
        public static ElectricResistivity From(double value, ElectricResistivityUnit fromUnit)
        {
            return new ElectricResistivity(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricResistivityUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ElectricResistivity ToUnit(ElectricResistivityUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ElectricResistivity(convertedValue, unit);
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
                ElectricResistivityUnit.KiloohmCentimeter => (_value / 100) * 1e3d,
                ElectricResistivityUnit.KiloohmMeter => (_value) * 1e3d,
                ElectricResistivityUnit.MegaohmCentimeter => (_value / 100) * 1e6d,
                ElectricResistivityUnit.MegaohmMeter => (_value) * 1e6d,
                ElectricResistivityUnit.MicroohmCentimeter => (_value / 100) * 1e-6d,
                ElectricResistivityUnit.MicroohmMeter => (_value) * 1e-6d,
                ElectricResistivityUnit.MilliohmCentimeter => (_value / 100) * 1e-3d,
                ElectricResistivityUnit.MilliohmMeter => (_value) * 1e-3d,
                ElectricResistivityUnit.NanoohmCentimeter => (_value / 100) * 1e-9d,
                ElectricResistivityUnit.NanoohmMeter => (_value) * 1e-9d,
                ElectricResistivityUnit.OhmCentimeter => _value / 100,
                ElectricResistivityUnit.OhmMeter => _value,
                ElectricResistivityUnit.PicoohmCentimeter => (_value / 100) * 1e-12d,
                ElectricResistivityUnit.PicoohmMeter => (_value) * 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(ElectricResistivityUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                ElectricResistivityUnit.KiloohmCentimeter => (baseUnitValue * 100) / 1e3d,
                ElectricResistivityUnit.KiloohmMeter => (baseUnitValue) / 1e3d,
                ElectricResistivityUnit.MegaohmCentimeter => (baseUnitValue * 100) / 1e6d,
                ElectricResistivityUnit.MegaohmMeter => (baseUnitValue) / 1e6d,
                ElectricResistivityUnit.MicroohmCentimeter => (baseUnitValue * 100) / 1e-6d,
                ElectricResistivityUnit.MicroohmMeter => (baseUnitValue) / 1e-6d,
                ElectricResistivityUnit.MilliohmCentimeter => (baseUnitValue * 100) / 1e-3d,
                ElectricResistivityUnit.MilliohmMeter => (baseUnitValue) / 1e-3d,
                ElectricResistivityUnit.NanoohmCentimeter => (baseUnitValue * 100) / 1e-9d,
                ElectricResistivityUnit.NanoohmMeter => (baseUnitValue) / 1e-9d,
                ElectricResistivityUnit.OhmCentimeter => baseUnitValue * 100,
                ElectricResistivityUnit.OhmMeter => baseUnitValue,
                ElectricResistivityUnit.PicoohmCentimeter => (baseUnitValue * 100) / 1e-12d,
                ElectricResistivityUnit.PicoohmMeter => (baseUnitValue) / 1e-12d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

