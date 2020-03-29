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
        private static MLContext mlContext = new MLContext();
        private static ModelInput input = new ModelInput();
        private static string modelPath = Path.Combine
                    (Environment.CurrentDirectory, "Model", "MLModel.zip");
        private static ITransformer mlModel;
        private static PredictionEngine<ModelInput, ModelOutput> predEngine;
        private static void Init()
        {
            mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
        public static (bool Result, float Score) Predict(string s)
        {
            if (mlModel == null) Init();    // load engine on first use only.
            input.Text = s;
            ModelOutput result = predEngine.Predict(input);
            return (result.Prediction, result.Score);
        }
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
