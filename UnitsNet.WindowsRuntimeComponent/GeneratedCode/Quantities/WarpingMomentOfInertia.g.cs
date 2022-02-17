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
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     A geometric property of an area that is used to determine the warping stress.
    /// </summary>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class WarpingMomentOfInertia : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly WarpingMomentOfInertiaUnit? _unit;

        static WarpingMomentOfInertia()
        {
            BaseDimensions = new BaseDimensions(6, 0, 0, 0, 0, 0, 0);
            BaseUnit = WarpingMomentOfInertiaUnit.MeterToTheSixth;
            MaxValue = new WarpingMomentOfInertia(double.MaxValue, BaseUnit);
            MinValue = new WarpingMomentOfInertia(double.MinValue, BaseUnit);
            QuantityType = QuantityType.WarpingMomentOfInertia;
            Units = Enum.GetValues(typeof(WarpingMomentOfInertiaUnit)).Cast<WarpingMomentOfInertiaUnit>().Except(new WarpingMomentOfInertiaUnit[]{ WarpingMomentOfInertiaUnit.Undefined }).ToArray();
            Zero = new WarpingMomentOfInertia(0, BaseUnit);
            Info = new QuantityInfo(QuantityType.WarpingMomentOfInertia, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit MeterToTheSixth.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public WarpingMomentOfInertia()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private WarpingMomentOfInertia(double value, WarpingMomentOfInertiaUnit unit)
        {
            if (unit == WarpingMomentOfInertiaUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(value, nameof(value));
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of WarpingMomentOfInertia, which is MeterToTheSixth. All conversions go via this value.
        /// </summary>
        public static WarpingMomentOfInertiaUnit BaseUnit { get; }

        /// <summary>
        /// Represents the largest possible value of WarpingMomentOfInertia
        /// </summary>
        public static WarpingMomentOfInertia MaxValue { get; }

        /// <summary>
        /// Represents the smallest possible value of WarpingMomentOfInertia
        /// </summary>
        public static WarpingMomentOfInertia MinValue { get; }

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public static QuantityType QuantityType { get; }

        /// <summary>
        ///     All units of measurement for the WarpingMomentOfInertia quantity.
        /// </summary>
        public static WarpingMomentOfInertiaUnit[] Units { get; }

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit MeterToTheSixth.
        /// </summary>
        public static WarpingMomentOfInertia Zero { get; }

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => Convert.ToDouble(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public WarpingMomentOfInertiaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        [Obsolete("QuantityType will be removed in the future. Use the Info property instead.")]
        public QuantityType Type => WarpingMomentOfInertia.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => WarpingMomentOfInertia.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.CentimeterToTheSixth">CentimetersToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToCentimetersToTheSixth property.")]
        public double CentimetersToTheSixth => As(WarpingMomentOfInertiaUnit.CentimeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.DecimeterToTheSixth">DecimetersToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToDecimetersToTheSixth property.")]
        public double DecimetersToTheSixth => As(WarpingMomentOfInertiaUnit.DecimeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.FootToTheSixth">FeetToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToFeetToTheSixth property.")]
        public double FeetToTheSixth => As(WarpingMomentOfInertiaUnit.FootToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.InchToTheSixth">InchesToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToInchesToTheSixth property.")]
        public double InchesToTheSixth => As(WarpingMomentOfInertiaUnit.InchToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.MeterToTheSixth">MetersToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMetersToTheSixth property.")]
        public double MetersToTheSixth => As(WarpingMomentOfInertiaUnit.MeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.MillimeterToTheSixth">MillimetersToTheSixth</see> as a <see cref="double"/>.
        /// </summary>
        [Obsolete("Use the ToMillimetersToTheSixth property.")]
        public double MillimetersToTheSixth => As(WarpingMomentOfInertiaUnit.MillimeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.CentimeterToTheSixth">CentimetersToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToCentimetersToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.CentimeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.DecimeterToTheSixth">DecimetersToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToDecimetersToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.DecimeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.FootToTheSixth">FeetToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToFeetToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.FootToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.InchToTheSixth">InchesToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToInchesToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.InchToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.MeterToTheSixth">MetersToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToMetersToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.MeterToTheSixth);

        /// <summary>
        ///     Gets this <see cref="WarpingMomentOfInertia"/> converted into <see cref="WarpingMomentOfInertiaUnit.MillimeterToTheSixth">MillimetersToTheSixth</see>.
        /// </summary>
        public WarpingMomentOfInertia ToMillimetersToTheSixth => ToUnit(WarpingMomentOfInertiaUnit.MillimeterToTheSixth);

        #endregion

        #region Static Methods

        internal static void MapGeneratedLocalizations(UnitAbbreviationsCache unitAbbreviationsCache)
        {
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.CentimeterToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"cm⁶", "cm^6"});
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.DecimeterToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"dm⁶", "dm^6"});
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.FootToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"ft⁶", "ft^6"});
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.InchToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"in⁶", "in^6"});
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.MeterToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"m⁶", "m^6"});
            unitAbbreviationsCache.PerformAbbreviationMapping(WarpingMomentOfInertiaUnit.MillimeterToTheSixth, new CultureInfo("en-US"), false, true, new string[]{"mm⁶", "mm^6"});
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(WarpingMomentOfInertiaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(WarpingMomentOfInertiaUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.CentimeterToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromCentimetersToTheSixth(double centimeterstothesixth)
        {
            double value = (double) centimeterstothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.CentimeterToTheSixth);
        }

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.DecimeterToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromDecimetersToTheSixth(double decimeterstothesixth)
        {
            double value = (double) decimeterstothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.DecimeterToTheSixth);
        }

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.FootToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromFeetToTheSixth(double feettothesixth)
        {
            double value = (double) feettothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.FootToTheSixth);
        }

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.InchToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromInchesToTheSixth(double inchestothesixth)
        {
            double value = (double) inchestothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.InchToTheSixth);
        }

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.MeterToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromMetersToTheSixth(double meterstothesixth)
        {
            double value = (double) meterstothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MeterToTheSixth);
        }

        /// <summary>
        ///     Creates a <see cref="WarpingMomentOfInertia"/> from <see cref="WarpingMomentOfInertiaUnit.MillimeterToTheSixth"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static WarpingMomentOfInertia FromMillimetersToTheSixth(double millimeterstothesixth)
        {
            double value = (double) millimeterstothesixth;
            return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MillimeterToTheSixth);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="WarpingMomentOfInertiaUnit" /> to <see cref="WarpingMomentOfInertia" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>WarpingMomentOfInertia unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static WarpingMomentOfInertia From(double value, WarpingMomentOfInertiaUnit fromUnit)
        {
            return new WarpingMomentOfInertia((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static WarpingMomentOfInertia Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static WarpingMomentOfInertia Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<WarpingMomentOfInertia, WarpingMomentOfInertiaUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out WarpingMomentOfInertia result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out WarpingMomentOfInertia result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<WarpingMomentOfInertia, WarpingMomentOfInertiaUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static WarpingMomentOfInertiaUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static WarpingMomentOfInertiaUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<WarpingMomentOfInertiaUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out WarpingMomentOfInertiaUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out WarpingMomentOfInertiaUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<WarpingMomentOfInertiaUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            if (!(obj is WarpingMomentOfInertia objWarpingMomentOfInertia)) throw new ArgumentException("Expected type WarpingMomentOfInertia.", nameof(obj));

            return CompareTo(objWarpingMomentOfInertia);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(WarpingMomentOfInertia other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is WarpingMomentOfInertia objWarpingMomentOfInertia))
                return false;

            return Equals(objWarpingMomentOfInertia);
        }

        public bool Equals(WarpingMomentOfInertia other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another WarpingMomentOfInertia within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(WarpingMomentOfInertia other, double tolerance, ComparisonType comparisonType)
        {
            if (tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current WarpingMomentOfInertia.</returns>
        public override int GetHashCode()
        {
            return new { Info.Name, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(object unit) => As((WarpingMomentOfInertiaUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(WarpingMomentOfInertiaUnit unit)
        {
            if (Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this WarpingMomentOfInertia to another WarpingMomentOfInertia with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A WarpingMomentOfInertia with the specified unit.</returns>
        public WarpingMomentOfInertia ToUnit(WarpingMomentOfInertiaUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new WarpingMomentOfInertia(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case WarpingMomentOfInertiaUnit.CentimeterToTheSixth: return _value / 1e12;
                case WarpingMomentOfInertiaUnit.DecimeterToTheSixth: return _value / 1e6;
                case WarpingMomentOfInertiaUnit.FootToTheSixth: return _value * Math.Pow(0.3048, 6);
                case WarpingMomentOfInertiaUnit.InchToTheSixth: return _value * Math.Pow(2.54e-2, 6);
                case WarpingMomentOfInertiaUnit.MeterToTheSixth: return _value;
                case WarpingMomentOfInertiaUnit.MillimeterToTheSixth: return _value / 1e18;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(WarpingMomentOfInertiaUnit unit)
        {
            if (Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case WarpingMomentOfInertiaUnit.CentimeterToTheSixth: return baseUnitValue * 1e12;
                case WarpingMomentOfInertiaUnit.DecimeterToTheSixth: return baseUnitValue * 1e6;
                case WarpingMomentOfInertiaUnit.FootToTheSixth: return baseUnitValue / Math.Pow(0.3048, 6);
                case WarpingMomentOfInertiaUnit.InchToTheSixth: return baseUnitValue / Math.Pow(2.54e-2, 6);
                case WarpingMomentOfInertiaUnit.MeterToTheSixth: return baseUnitValue;
                case WarpingMomentOfInertiaUnit.MillimeterToTheSixth: return baseUnitValue * 1e18;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
