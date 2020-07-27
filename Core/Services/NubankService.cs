using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models;
using Core.Models.Nubank;
using Microcharts;
using SkiaSharp;

namespace Core.Services
{
    public class NubankService : INubank
    {
        private IList<NubankTimelineModel> _items;
        private IList<NubankHeaderModel> _headers;

        public NubankService()
        {
            _items = new List<NubankTimelineModel>();
            _headers = new List<NubankHeaderModel>();

            _items.Add(GetNubankTimelineModel(
                category: "Eletrônicos",
                categoryIcon: "nubank_cat_eletronics",
                textColor: "#000000",
                description: "Mercadopago",
                localPrice: 419.99,
                isDollar: false,
                dollarPrice: null,
                isInstallment: true,
                numberOfInstallments: 4,
                createdAt: DateTime.Now,
                isReversed: false,
                tags: new List<string>() { "Compras" }
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Restaurante",
                categoryIcon: "nubank_cat_restaurant",
                textColor: "#000000",
                description: "Tio Patinhas",
                localPrice: 16.90,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddHours(-3),
                isReversed: false,
                tags: new List<string>() { "Almoço" }
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Eletrônicos",
                categoryIcon: "nubank_cat_eletronics",
                textColor: "#000000",
                description: "Apl Appleonlinestoreus",
                localPrice: 387.56,
                isDollar: true,
                dollarPrice: 99.00,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-1),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Serviços",
                categoryIcon: "nubank_cat_services",
                textColor: "#000000",
                description: "Apl* Itunes.Com/Bill",
                localPrice: 3.91,
                isDollar: true,
                dollarPrice: 1.00,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-1).AddHours(-1),
                isReversed: true,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Fatura Paga",
                categoryIcon: "nubank_cat_bullet_green",
                textColor: "#80cd00",
                description: null,
                localPrice: null,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-2).AddHours(-1),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Pagamento recebido",
                categoryIcon: "nubank_cat_bullet_green",
                textColor: "#80cd00",
                description: null,
                localPrice: 1234.56,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-2).AddHours(-2),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Transporte",
                categoryIcon: "nubank_cat_transport",
                textColor: "#000000",
                description: "Posto Cidade",
                localPrice: 9.35,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-3),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Fatura Fechada",
                categoryIcon: "nubank_cat_bullet_red",
                textColor: "#f64d59",
                description: "Vence em 10/05, e hoje é o melhor dia para compras",
                localPrice: 1234.56,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-5),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Restaurante",
                categoryIcon: "nubank_cat_restaurant",
                textColor: "#000000",
                description: "Ifood*Br",
                localPrice: 80.70,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-7),
                isReversed: false,
                tags: new List<string>() {"Jantar", "Happy Hour"}
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Serviços",
                categoryIcon: "nubank_cat_services",
                textColor: "#000000",
                description: "Netflix.Com",
                localPrice: 37.90,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-8),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Lazer",
                categoryIcon: "nubank_cat_recreation",
                textColor: "#000000",
                description: "Toni Toys",
                localPrice: 291.98,
                isDollar: false,
                dollarPrice: null,
                isInstallment: true,
                numberOfInstallments: 2,
                createdAt: DateTime.Now.AddDays(-10),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Seu Cartão Está",
                categoryIcon: "nubank_cat_card",
                textColor: "#000000",
                description: "Desbloqueado",
                localPrice: null,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-15),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Limite Inicial",
                categoryIcon: "nubank_cat_bullet_green",
                textColor: "#80cd00",
                description: null,
                localPrice: 1000.00,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-15).AddHours(-1),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Veja Como Funciona",
                categoryIcon: "nubank_cat_play",
                textColor: "#000000",
                description: null,
                localPrice: null,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-15).AddHours(-1),
                isReversed: false,
                tags: new List<string>()
            ));

            _items.Add(GetNubankTimelineModel(
                category: "Bem-Vindo ao",
                categoryIcon: "nubank_cat_star",
                textColor: "#000000",
                description: "Nubank!",
                localPrice: null,
                isDollar: false,
                dollarPrice: null,
                isInstallment: false,
                numberOfInstallments: null,
                createdAt: DateTime.Now.AddDays(-15).AddHours(-2),
                isReversed: false,
                tags: new List<string>()
            ));

            _headers.Add(GetHeader(
                description: "Você fez 51 compras nos últimos 30 dias, com um total de R$ 273,77"
            ));

            _headers.Add(GetHeader(
                total: 249.91
            ));
        }

        public IList<NubankHeaderModel> GetHeader()
        {
            return _headers;
        }

        public IList<NubankTimelineModel> GetTimeline()
        {
            return _items;
        }

        private NubankTimelineModel GetNubankTimelineModel(
            string category,
            string categoryIcon,
            string textColor,
            string description,
            double? localPrice,
            bool isDollar,
            double? dollarPrice,
            bool isInstallment,
            int? numberOfInstallments,
            DateTimeOffset createdAt,
            bool isReversed,
            IList<string> tags
        ) {
            return new NubankTimelineModel()
            {
                Category = category,
                CategoryIcon = categoryIcon,
                TextColor = textColor,
                Description = description,
                LocalPrice = localPrice,
                IsDollar = isDollar,
                DollarPrice = dollarPrice,
                IsInstallment = isInstallment,
                NumberOfInstallments = numberOfInstallments,
                CreatedAt = createdAt,
                IsReversed = isReversed,
                Tags = tags
            };
        }

        private ChartEntry GetEntry(float value)
        {
            var color = "#00c0cd";

            return new ChartEntry(value)
            {
                Color = SKColor.Parse(color),
                TextColor = SKColor.Parse(color)
            };
        }
        private NubankHeaderModel GetHeader(
            string description)
        {
            var entries = new[]
            {
                GetEntry(0),
                GetEntry(50),
                GetEntry(0),
                GetEntry(15),
                GetEntry(0),
                GetEntry(15),
                GetEntry(0),
                GetEntry(70),
                GetEntry(-20),
                GetEntry(110),
                GetEntry(10),
                GetEntry(30),
                GetEntry(15),
                GetEntry(20),
                GetEntry(110),
                GetEntry(50),
                GetEntry(20),
                GetEntry(50),
                GetEntry(5),
                GetEntry(15)
            };

            var chart = new LineChart()
            {
                Entries = entries,
                LineMode = LineMode.Straight,
                PointMode = PointMode.None,
                LineSize = 4,
                BackgroundColor = SKColors.Transparent
            };

            return new NubankHeaderSummaryModel()
            {
                Chart = chart,
                Description = description
            };
        }

        private NubankHeaderModel GetHeader(
            double total)
        {
            return new NubankHeaderInvoiceModel()
            {
                Total = total
            };
        }
    }
}
