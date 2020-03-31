// Thai Sentiment Analytic by Loy [ThaiSenLoy]
// https://github.com/laploy/ThaiSenLoy
// Laploy 2020

using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;

namespace Laploy.ThaiSen.ML
{
    public static class ThaiSen
    {
        private static MLContext _backedContext;
        private static MLContext MlContext
        {
            get
            {
                //defer until needed.
                return _backedContext ?? (_backedContext = new MLContext());
            }
        }
        private static readonly ModelInput input = new ModelInput();
        private static readonly string modelPath = Path.Combine
                    (Environment.CurrentDirectory, "Model", "MLModel.zip");
        private static ITransformer mlModel;
        private static PredictionEngine<ModelInput, ModelOutput> predEngine;
        private static void Init()
        {
            mlModel = MlContext.Model.Load(modelPath, out var modelInputSchema);
            predEngine = MlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
        /// <summary>
        /// Predict given string and return a predict result with confidence score.
        /// </summary>
        /// <param name="s">String to predict.</param>
        /// <returns>A predict result with confidence score.</returns>
        public static (SentimentPredictionResult Result, float Score) Predict(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return (SentimentPredictionResult.Unknown, -1);
            input.Text = s;
            var result = Predict(input);
            var predictionResult = result.Prediction ? SentimentPredictionResult.Negative : SentimentPredictionResult.Positive;
            return (predictionResult, result.Score);
        }
        /// <summary>
        /// Predict given ModelInput and return ModelOutput.
        /// </summary>
        /// <param name="param">A ModelInput instance.</param>
        /// <returns>A ModelOutput instance.</returns>
        public static ModelOutput Predict(ModelInput param)
        {
            if (mlModel == null) Init();  // load engine on first use only.
            var result = predEngine.Predict(param);
            return result;
        }
    }
    public enum SentimentPredictionResult
    {
        Negative = -1,
        Unknown = 0, //just in case we want to combine prediction with confidence score, this one might come in handy.
        Positive = 1
    }
    public class ModelInput
    {
        [ColumnName("text"), LoadColumn(0)]
        public string Text { get; set; }
        [ColumnName("label"), LoadColumn(1)]
        public bool Label { get; set; }
    }
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public bool Prediction { get; set; }
        public float Score { get; set; }
    }

}
