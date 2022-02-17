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
    ///     In physics, mass (from Greek μᾶζα "barley cake, lump [of dough]") is a property of a physical system or body, giving rise to the phenomena of the body's resistance to being accelerated by a force and the strength of its mutual gravitational attraction with other bodies. Instruments such as mass balances or scales use those phenomena to measure mass. The SI unit of mass is the kilogram (kg).
    /// </summary>
    public struct  Mass
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MassUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Mass(double value, MassUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MassUnit BaseUnit { get; } = MassUnit.Kilogram;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Mass MaxValue { get; } = new Mass(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Mass MinValue { get; } = new Mass(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Mass Zero { get; } = new Mass(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Centigram">Centigrams</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToCentigrams property.")]
        public double Centigrams => As(MassUnit.Centigram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Decagram">Decagrams</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecagrams property.")]
        public double Decagrams => As(MassUnit.Decagram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Decigram">Decigrams</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecigrams property.")]
        public double Decigrams => As(MassUnit.Decigram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.EarthMass">EarthMasses</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToEarthMasses property.")]
        public double EarthMasses => As(MassUnit.EarthMass);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Grain">Grains</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToGrains property.")]
        public double Grains => As(MassUnit.Grain);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Gram">Grams</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToGrams property.")]
        public double Grams => As(MassUnit.Gram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Hectogram">Hectograms</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToHectograms property.")]
        public double Hectograms => As(MassUnit.Hectogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilogram">Kilograms</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilograms property.")]
        public double Kilograms => As(MassUnit.Kilogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilopound">Kilopounds</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilopounds property.")]
        public double Kilopounds => As(MassUnit.Kilopound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilotonne">Kilotonnes</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToKilotonnes property.")]
        public double Kilotonnes => As(MassUnit.Kilotonne);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.LongHundredweight">LongHundredweight</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToLongHundredweight property.")]
        public double LongHundredweight => As(MassUnit.LongHundredweight);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.LongTon">LongTons</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToLongTons property.")]
        public double LongTons => As(MassUnit.LongTon);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Megapound">Megapounds</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegapounds property.")]
        public double Megapounds => As(MassUnit.Megapound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Megatonne">Megatonnes</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMegatonnes property.")]
        public double Megatonnes => As(MassUnit.Megatonne);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Microgram">Micrograms</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMicrograms property.")]
        public double Micrograms => As(MassUnit.Microgram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Milligram">Milligrams</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMilligrams property.")]
        public double Milligrams => As(MassUnit.Milligram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Nanogram">Nanograms</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToNanograms property.")]
        public double Nanograms => As(MassUnit.Nanogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Ounce">Ounces</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToOunces property.")]
        public double Ounces => As(MassUnit.Ounce);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Pound">Pounds</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToPounds property.")]
        public double Pounds => As(MassUnit.Pound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.ShortHundredweight">ShortHundredweight</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToShortHundredweight property.")]
        public double ShortHundredweight => As(MassUnit.ShortHundredweight);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.ShortTon">ShortTons</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToShortTons property.")]
        public double ShortTons => As(MassUnit.ShortTon);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Slug">Slugs</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToSlugs property.")]
        public double Slugs => As(MassUnit.Slug);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.SolarMass">SolarMasses</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToSolarMasses property.")]
        public double SolarMasses => As(MassUnit.SolarMass);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Stone">Stone</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToStone property.")]
        public double Stone => As(MassUnit.Stone);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Tonne">Tonnes</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToTonnes property.")]
        public double Tonnes => As(MassUnit.Tonne);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Centigram">Centigrams</see>.
        /// </summary>
        public Mass ToCentigrams => ToUnit(MassUnit.Centigram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Decagram">Decagrams</see>.
        /// </summary>
        public Mass ToDecagrams => ToUnit(MassUnit.Decagram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Decigram">Decigrams</see>.
        /// </summary>
        public Mass ToDecigrams => ToUnit(MassUnit.Decigram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.EarthMass">EarthMasses</see>.
        /// </summary>
        public Mass ToEarthMasses => ToUnit(MassUnit.EarthMass);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Grain">Grains</see>.
        /// </summary>
        public Mass ToGrains => ToUnit(MassUnit.Grain);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Gram">Grams</see>.
        /// </summary>
        public Mass ToGrams => ToUnit(MassUnit.Gram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Hectogram">Hectograms</see>.
        /// </summary>
        public Mass ToHectograms => ToUnit(MassUnit.Hectogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilogram">Kilograms</see>.
        /// </summary>
        public Mass ToKilograms => ToUnit(MassUnit.Kilogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilopound">Kilopounds</see>.
        /// </summary>
        public Mass ToKilopounds => ToUnit(MassUnit.Kilopound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Kilotonne">Kilotonnes</see>.
        /// </summary>
        public Mass ToKilotonnes => ToUnit(MassUnit.Kilotonne);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.LongHundredweight">LongHundredweight</see>.
        /// </summary>
        public Mass ToLongHundredweight => ToUnit(MassUnit.LongHundredweight);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.LongTon">LongTons</see>.
        /// </summary>
        public Mass ToLongTons => ToUnit(MassUnit.LongTon);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Megapound">Megapounds</see>.
        /// </summary>
        public Mass ToMegapounds => ToUnit(MassUnit.Megapound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Megatonne">Megatonnes</see>.
        /// </summary>
        public Mass ToMegatonnes => ToUnit(MassUnit.Megatonne);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Microgram">Micrograms</see>.
        /// </summary>
        public Mass ToMicrograms => ToUnit(MassUnit.Microgram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Milligram">Milligrams</see>.
        /// </summary>
        public Mass ToMilligrams => ToUnit(MassUnit.Milligram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Nanogram">Nanograms</see>.
        /// </summary>
        public Mass ToNanograms => ToUnit(MassUnit.Nanogram);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Ounce">Ounces</see>.
        /// </summary>
        public Mass ToOunces => ToUnit(MassUnit.Ounce);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Pound">Pounds</see>.
        /// </summary>
        public Mass ToPounds => ToUnit(MassUnit.Pound);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.ShortHundredweight">ShortHundredweight</see>.
        /// </summary>
        public Mass ToShortHundredweight => ToUnit(MassUnit.ShortHundredweight);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.ShortTon">ShortTons</see>.
        /// </summary>
        public Mass ToShortTons => ToUnit(MassUnit.ShortTon);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Slug">Slugs</see>.
        /// </summary>
        public Mass ToSlugs => ToUnit(MassUnit.Slug);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.SolarMass">SolarMasses</see>.
        /// </summary>
        public Mass ToSolarMasses => ToUnit(MassUnit.SolarMass);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Stone">Stone</see>.
        /// </summary>
        public Mass ToStone => ToUnit(MassUnit.Stone);

        /// <summary>
        ///     Gets this <see cref="Mass"/> converted into <see cref="MassUnit.Tonne">Tonnes</see>.
        /// </summary>
        public Mass ToTonnes => ToUnit(MassUnit.Tonne);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Centigram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromCentigrams(double centigrams) => new Mass(centigrams, MassUnit.Centigram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Decagram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromDecagrams(double decagrams) => new Mass(decagrams, MassUnit.Decagram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Decigram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromDecigrams(double decigrams) => new Mass(decigrams, MassUnit.Decigram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.EarthMass"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromEarthMasses(double earthmasses) => new Mass(earthmasses, MassUnit.EarthMass);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Grain"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromGrains(double grains) => new Mass(grains, MassUnit.Grain);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Gram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromGrams(double grams) => new Mass(grams, MassUnit.Gram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Hectogram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromHectograms(double hectograms) => new Mass(hectograms, MassUnit.Hectogram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Kilogram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilograms(double kilograms) => new Mass(kilograms, MassUnit.Kilogram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Kilopound"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilopounds(double kilopounds) => new Mass(kilopounds, MassUnit.Kilopound);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Kilotonne"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromKilotonnes(double kilotonnes) => new Mass(kilotonnes, MassUnit.Kilotonne);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.LongHundredweight"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromLongHundredweight(double longhundredweight) => new Mass(longhundredweight, MassUnit.LongHundredweight);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.LongTon"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromLongTons(double longtons) => new Mass(longtons, MassUnit.LongTon);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Megapound"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMegapounds(double megapounds) => new Mass(megapounds, MassUnit.Megapound);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Megatonne"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMegatonnes(double megatonnes) => new Mass(megatonnes, MassUnit.Megatonne);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Microgram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMicrograms(double micrograms) => new Mass(micrograms, MassUnit.Microgram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Milligram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromMilligrams(double milligrams) => new Mass(milligrams, MassUnit.Milligram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Nanogram"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromNanograms(double nanograms) => new Mass(nanograms, MassUnit.Nanogram);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Ounce"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromOunces(double ounces) => new Mass(ounces, MassUnit.Ounce);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Pound"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromPounds(double pounds) => new Mass(pounds, MassUnit.Pound);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.ShortHundredweight"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromShortHundredweight(double shorthundredweight) => new Mass(shorthundredweight, MassUnit.ShortHundredweight);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.ShortTon"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromShortTons(double shorttons) => new Mass(shorttons, MassUnit.ShortTon);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Slug"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromSlugs(double slugs) => new Mass(slugs, MassUnit.Slug);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.SolarMass"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromSolarMasses(double solarmasses) => new Mass(solarmasses, MassUnit.SolarMass);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Stone"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromStone(double stone) => new Mass(stone, MassUnit.Stone);

        /// <summary>
        ///     Creates a <see cref="Mass"/> from <see cref="MassUnit.Tonne"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Mass FromTonnes(double tonnes) => new Mass(tonnes, MassUnit.Tonne);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassUnit" /> to <see cref="Mass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Mass unit value.</returns>
        public static Mass From(double value, MassUnit fromUnit)
        {
            return new Mass(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Mass ToUnit(MassUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new Mass(convertedValue, unit);
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
                MassUnit.Centigram => (_value / 1e3) * 1e-2d,
                MassUnit.Decagram => (_value / 1e3) * 1e1d,
                MassUnit.Decigram => (_value / 1e3) * 1e-1d,
                MassUnit.EarthMass => _value * 5.9722E+24,
                MassUnit.Grain => _value / 15432.358352941431,
                MassUnit.Gram => _value / 1e3,
                MassUnit.Hectogram => (_value / 1e3) * 1e2d,
                MassUnit.Kilogram => (_value / 1e3) * 1e3d,
                MassUnit.Kilopound => (_value * 0.45359237) * 1e3d,
                MassUnit.Kilotonne => (_value * 1e3) * 1e3d,
                MassUnit.LongHundredweight => _value / 0.01968413055222121,
                MassUnit.LongTon => _value * 1.0160469088e3,
                MassUnit.Megapound => (_value * 0.45359237) * 1e6d,
                MassUnit.Megatonne => (_value * 1e3) * 1e6d,
                MassUnit.Microgram => (_value / 1e3) * 1e-6d,
                MassUnit.Milligram => (_value / 1e3) * 1e-3d,
                MassUnit.Nanogram => (_value / 1e3) * 1e-9d,
                MassUnit.Ounce => _value / 35.2739619,
                MassUnit.Pound => _value * 0.45359237,
                MassUnit.ShortHundredweight => _value / 0.022046226218487758,
                MassUnit.ShortTon => _value * 9.0718474e2,
                MassUnit.Slug => _value / 6.852176556196105e-2,
                MassUnit.SolarMass => _value * 1.98947e30,
                MassUnit.Stone => _value / 0.1574731728702698,
                MassUnit.Tonne => _value * 1e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
            };
        }

        private double GetValueAs(MassUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            return unit switch
            {
                MassUnit.Centigram => (baseUnitValue * 1e3) / 1e-2d,
                MassUnit.Decagram => (baseUnitValue * 1e3) / 1e1d,
                MassUnit.Decigram => (baseUnitValue * 1e3) / 1e-1d,
                MassUnit.EarthMass => baseUnitValue / 5.9722E+24,
                MassUnit.Grain => baseUnitValue * 15432.358352941431,
                MassUnit.Gram => baseUnitValue * 1e3,
                MassUnit.Hectogram => (baseUnitValue * 1e3) / 1e2d,
                MassUnit.Kilogram => (baseUnitValue * 1e3) / 1e3d,
                MassUnit.Kilopound => (baseUnitValue / 0.45359237) / 1e3d,
                MassUnit.Kilotonne => (baseUnitValue / 1e3) / 1e3d,
                MassUnit.LongHundredweight => baseUnitValue * 0.01968413055222121,
                MassUnit.LongTon => baseUnitValue / 1.0160469088e3,
                MassUnit.Megapound => (baseUnitValue / 0.45359237) / 1e6d,
                MassUnit.Megatonne => (baseUnitValue / 1e3) / 1e6d,
                MassUnit.Microgram => (baseUnitValue * 1e3) / 1e-6d,
                MassUnit.Milligram => (baseUnitValue * 1e3) / 1e-3d,
                MassUnit.Nanogram => (baseUnitValue * 1e3) / 1e-9d,
                MassUnit.Ounce => baseUnitValue * 35.2739619,
                MassUnit.Pound => baseUnitValue / 0.45359237,
                MassUnit.ShortHundredweight => baseUnitValue * 0.022046226218487758,
                MassUnit.ShortTon => baseUnitValue / 9.0718474e2,
                MassUnit.Slug => baseUnitValue * 6.852176556196105e-2,
                MassUnit.SolarMass => baseUnitValue / 1.98947e30,
                MassUnit.Stone => baseUnitValue * 0.1574731728702698,
                MassUnit.Tonne => baseUnitValue / 1e3,
                _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
            };
        }

        #endregion
    }
}

