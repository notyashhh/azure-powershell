// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>Enum for all forecasting models supported by AutoML.</summary>
    public partial struct ForecastingModels :
        System.IEquatable<ForecastingModels>
    {
        /// <summary>
        /// An Autoregressive Integrated Moving Average with Explanatory Variable (ARIMAX) model can be viewed as a multiple regression
        /// model with one or more autoregressive (AR) terms and/or one or more moving average (MA) terms.
        /// This method is suitable for forecasting when data is stationary/non stationary, and multivariate with any type of data
        /// pattern, i.e., level/trend /seasonality/cyclicity.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Arimax = @"Arimax";

        /// <summary>
        /// Auto-Autoregressive Integrated Moving Average (ARIMA) model uses time-series data and statistical analysis to interpret
        /// the data and make future predictions.
        /// This model aims to explain data by using time series data on its past values and uses linear regression to make predictions.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels AutoArima = @"AutoArima";

        /// <summary>
        /// The Average forecasting model makes predictions by carrying forward the average of the target values for each time-series
        /// in the training data.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Average = @"Average";

        /// <summary>
        /// Decision Trees are a non-parametric supervised learning method used for both classification and regression tasks.
        /// The goal is to create a model that predicts the value of a target variable by learning simple decision rules inferred
        /// from the data features.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels DecisionTree = @"DecisionTree";

        /// <summary>
        /// Elastic net is a popular type of regularized linear regression that combines two popular penalties, specifically the L1
        /// and L2 penalty functions.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels ElasticNet = @"ElasticNet";

        /// <summary>
        /// Exponential smoothing is a time series forecasting method for univariate data that can be extended to support data with
        /// a systematic trend or seasonal component.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels ExponentialSmoothing = @"ExponentialSmoothing";

        /// <summary>
        /// Extreme Trees is an ensemble machine learning algorithm that combines the predictions from many decision trees. It is
        /// related to the widely used random forest algorithm.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels ExtremeRandomTrees = @"ExtremeRandomTrees";

        /// <summary>
        /// The technique of transiting week learners into a strong learner is called Boosting. The gradient boosting algorithm process
        /// works on this theory of execution.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels GradientBoosting = @"GradientBoosting";

        /// <summary>
        /// K-nearest neighbors (KNN) algorithm uses 'feature similarity' to predict the values of new datapoints
        /// which further means that the new data point will be assigned a value based on how closely it matches the points in the
        /// training set.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Knn = @"KNN";

        /// <summary>
        /// Lasso model fit with Least Angle Regression a.k.a. Lars. It is a Linear Model trained with an L1 prior as regularizer.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels LassoLars = @"LassoLars";

        /// <summary>
        /// LightGBM is a gradient boosting framework that uses tree based learning algorithms.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels LightGbm = @"LightGBM";

        /// <summary>
        /// The Naive forecasting model makes predictions by carrying forward the latest target value for each time-series in the
        /// training data.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Naive = @"Naive";

        /// <summary>
        /// Prophet is a procedure for forecasting time series data based on an additive model where non-linear trends are fit with
        /// yearly, weekly, and daily seasonality, plus holiday effects.
        /// It works best with time series that have strong seasonal effects and several seasons of historical data. Prophet is robust
        /// to missing data and shifts in the trend, and typically handles outliers well.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Prophet = @"Prophet";

        /// <summary>
        /// Random forest is a supervised learning algorithm.
        /// The "forest" it builds, is an ensemble of decision trees, usually trained with the “bagging” method.
        /// The general idea of the bagging method is that a combination of learning models increases the overall result.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels RandomForest = @"RandomForest";

        /// <summary>
        /// The Seasonal Average forecasting model makes predictions by carrying forward the average value of the latest season of
        /// data for each time-series in the training data.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels SeasonalAverage = @"SeasonalAverage";

        /// <summary>
        /// The Seasonal Naive forecasting model makes predictions by carrying forward the latest season of target values for each
        /// time-series in the training data.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels SeasonalNaive = @"SeasonalNaive";

        /// <summary>
        /// SGD: Stochastic gradient descent is an optimization algorithm often used in machine learning applications
        /// to find the model parameters that correspond to the best fit between predicted and actual outputs.
        /// It's an inexact but powerful technique.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels Sgd = @"SGD";

        /// <summary>
        /// TCNForecaster: Temporal Convolutional Networks Forecaster. //TODO: Ask forecasting team for brief intro.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels TcnForecaster = @"TCNForecaster";

        /// <summary>
        /// XGBoostRegressor: Extreme Gradient Boosting Regressor is a supervised machine learning model using ensemble of base learners.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels XgBoostRegressor = @"XGBoostRegressor";

        /// <summary>the value for an instance of the <see cref="ForecastingModels" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ForecastingModels</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ForecastingModels" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ForecastingModels(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ForecastingModels</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ForecastingModels (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ForecastingModels && Equals((ForecastingModels)obj);
        }

        /// <summary>Creates an instance of the <see cref="ForecastingModels"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ForecastingModels(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ForecastingModels</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ForecastingModels</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ForecastingModels</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ForecastingModels" />.</param>

        public static implicit operator ForecastingModels(string value)
        {
            return new ForecastingModels(value);
        }

        /// <summary>Implicit operator to convert ForecastingModels to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ForecastingModels" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ForecastingModels</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ForecastingModels</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ForecastingModels e2)
        {
            return e2.Equals(e1);
        }
    }
}