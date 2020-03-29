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
        public static (bool Result, float Score) Predict(string s)
        {
            ModelInput input = new ModelInput();
            input.Text = s;
            MLContext mlContext = new MLContext();
            string modelPath = Path.Combine
                    (Environment.CurrentDirectory, "Model", "MLModel.zip");
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
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
