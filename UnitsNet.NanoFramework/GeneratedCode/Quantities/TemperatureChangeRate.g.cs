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
    ///     Temperature change rate is the ratio of the temperature change to the time during which the change occurred (value of temperature changes per unit time).
    /// </summary>
    public struct  TemperatureChangeRate
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly TemperatureChangeRateUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public TemperatureChangeRateUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public TemperatureChangeRate(double value, TemperatureChangeRateUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static TemperatureChangeRateUnit BaseUnit { get; } = TemperatureChangeRateUnit.DegreeCelsiusPerSecond;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MaxValue { get; } = new TemperatureChangeRate(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static TemperatureChangeRate MinValue { get; } = new TemperatureChangeRate(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static TemperatureChangeRate Zero { get; } = new TemperatureChangeRate(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond">CentidegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToCentidegreesCelsiusPerSecond property.")]
        public double CentidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond">DecadegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecadegreesCelsiusPerSecond property.")]
        public double DecadegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond">DecidegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecidegreesCelsiusPerSecond property.")]
        public double DecidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerMinute">DegreesCelsiusPerMinute</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDegreesCelsiusPerMinute property.")]
        public double DegreesCelsiusPerMinute => As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerSecond">DegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDegreesCelsiusPerSecond property.")]
        public double DegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond">HectodegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToHectodegreesCelsiusPerSecond property.")]
        public double HectodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond">KilodegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilodegreesCelsiusPerSecond property.")]
        public double KilodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond">MicrodegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMicrodegreesCelsiusPerSecond property.")]
        public double MicrodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond">MillidegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMillidegreesCelsiusPerSecond property.")]
        public double MillidegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond">NanodegreesCelsiusPerSecond</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNanodegreesCelsiusPerSecond property.")]
        public double NanodegreesCelsiusPerSecond => As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond">CentidegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToCentidegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond">DecadegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToDecadegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond">DecidegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToDecidegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerMinute">DegreesCelsiusPerMinute</see>.
        /// </summary>
        public TemperatureChangeRate ToDegreesCelsiusPerMinute => ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerSecond">DegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToDegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond">HectodegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToHectodegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond">KilodegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToKilodegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond">MicrodegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToMicrodegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond">MillidegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToMillidegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Gets this <see cref="TemperatureChangeRate"/> converted into <see cref="TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond">NanodegreesCelsiusPerSecond</see>.
        /// </summary>
        public TemperatureChangeRate ToNanodegreesCelsiusPerSecond => ToUnit(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(double centidegreescelsiuspersecond) => new TemperatureChangeRate(centidegreescelsiuspersecond, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(double decadegreescelsiuspersecond) => new TemperatureChangeRate(decadegreescelsiuspersecond, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(double decidegreescelsiuspersecond) => new TemperatureChangeRate(decidegreescelsiuspersecond, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerMinute"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerMinute(double degreescelsiusperminute) => new TemperatureChangeRate(degreescelsiusperminute, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.DegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromDegreesCelsiusPerSecond(double degreescelsiuspersecond) => new TemperatureChangeRate(degreescelsiuspersecond, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(double hectodegreescelsiuspersecond) => new TemperatureChangeRate(hectodegreescelsiuspersecond, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(double kilodegreescelsiuspersecond) => new TemperatureChangeRate(kilodegreescelsiuspersecond, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(double microdegreescelsiuspersecond) => new TemperatureChangeRate(microdegreescelsiuspersecond, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(double millidegreescelsiuspersecond) => new TemperatureChangeRate(millidegreescelsiuspersecond, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);

        /// <summary>
        ///     Creates a <see cref="TemperatureChangeRate"/> from <see cref="TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(double nanodegreescelsiuspersecond) => new TemperatureChangeRate(nanodegreescelsiuspersecond, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureChangeRateUnit" /> to <see cref="TemperatureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureChangeRate unit value.</returns>
        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit fromUnit)
        {
            return new TemperatureChangeRate(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(TemperatureChangeRateUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new TemperatureChangeRate(convertedValue, unit);
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
                TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond => (_value) * 1e-2d,
                TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond => (_value) * 1e1d,
                TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond => (_value) * 1e-1d,
                TemperatureChangeRateUnit.DegreeCelsiusPerMinute => _value / 60,
                TemperatureChangeRateUnit.DegreeCelsiusPerSecond => _value,
                TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond => (_value) * 1e2d,
                TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond => (_value) * 1e3d,
                TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond => (_value) * 1e-6d,
                TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond => (_value) * 1e-3d,
                TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond => (_value) * 1e-9d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(TemperatureChangeRateUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond => (baseUnitValue) / 1e-2d,
                TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond => (baseUnitValue) / 1e1d,
                TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond => (baseUnitValue) / 1e-1d,
                TemperatureChangeRateUnit.DegreeCelsiusPerMinute => baseUnitValue * 60,
                TemperatureChangeRateUnit.DegreeCelsiusPerSecond => baseUnitValue,
                TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond => (baseUnitValue) / 1e2d,
                TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond => (baseUnitValue) / 1e3d,
                TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond => (baseUnitValue) / 1e-6d,
                TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond => (baseUnitValue) / 1e-3d,
                TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond => (baseUnitValue) / 1e-9d,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

