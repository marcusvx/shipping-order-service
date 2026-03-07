using Microsoft.EntityFrameworkCore;
using ShippingOrderService.Web.Domain.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Seeders;

public class ShipmentSeeder(ShipmentDbContext context)
{
    public async Task SeedAsync()
    {
        if (await context.Shipments.AnyAsync()) return;

        var shipments = new List<Shipment>
        {
            Shipment.Create("João Silva", "01310-100", "20040-020", 3500.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Monitor 27\"", 6.5m, 2, true, new Dimensions(60m, 40m, 15m)),
                ShipmentItem.Create("Cadeira Gamer", 18m, 1, false, new Dimensions(70m, 120m, 70m))
            ]),
            Shipment.Create("Maria Souza", "30112-000", "01310-100", 800.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Notebook", 2.5m, 1, true, new Dimensions(35m, 25m, 3m))
            ]),
            Shipment.Create("Carlos Ferreira", "40301-110", "30112-000", 12000.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Servidor Rack", 35m, 1, true, new Dimensions(60m, 45m, 90m)),
                ShipmentItem.Create("Cabo de Rede Cat6", 0.5m, 10, false, new Dimensions(10m, 10m, 5m))
            ]),
            Shipment.Create("Ana Beatriz Oliveira", "80010-000", "88010-000", 450.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Kit Teclado e Mouse Sem Fio", 1.2m, 3, false, new Dimensions(50m, 20m, 5m))
            ]),
            Shipment.Create("Tech Solutions LTDA", "04578-000", "70040-010", 15200.50m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Projetor 4K profissional", 4.8m, 2, true, new Dimensions(40m, 30m, 20m)),
                ShipmentItem.Create("Tela de Projeção Retrátil", 12.0m, 1, false, new Dimensions(220m, 15m, 15m))
            ]),
            Shipment.Create("Ricardo Mendes", "60060-000", "01310-100", 2100.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Smartphone High-End", 0.4m, 1, true, new Dimensions(18m, 10m, 5m)),
                ShipmentItem.Create("Capa Protetora e Película", 0.1m, 1, false, new Dimensions(15m, 8m, 1m))
            ]),
            Shipment.Create("Fernanda Lima", "90010-000", "22041-001", 540.25m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Luminária de Mesa Articulada", 2.1m, 2, true, new Dimensions(30m, 30m, 50m))
            ]),
            Shipment.Create("Logistics Corp", "32210-110", "50010-000", 980.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Impressora Térmica de Etiquetas", 3.5m, 1, false, new Dimensions(25m, 20m, 20m)),
                ShipmentItem.Create("Bobinas Térmicas (Caixa)", 5.0m, 1, false, new Dimensions(30m, 30m, 30m))
            ]),
            Shipment.Create("Ana Pereira", "22290-240", "04538-132", 1500.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Impressora Multifuncional", 8.2m, 1, true, new Dimensions(45m, 35m, 25m))
            ]),
            Shipment.Create("Bruno Carvalho", "88010-400", "70040-010", 420.75m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Fones de Ouvido", 0.3m, 3, true, new Dimensions(15m, 10m, 8m)),
                ShipmentItem.Create("Mouse sem fio", 0.2m, 2, false, new Dimensions(12m, 8m, 5m))
            ]),
            Shipment.Create("Fernanda Alves", "64000-000", "59010-200", 9800.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Smart TV 65\"", 24m, 1, true, new Dimensions(160m, 95m, 20m)),
                ShipmentItem.Create("Soundbar", 6m, 1, true, new Dimensions(110m, 15m, 12m))
            ]),
            Shipment.Create("Ricardo Gomes", "69005-070", "80010-000", 230.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Livro Técnico", 1.1m, 4, false, new Dimensions(23m, 16m, 12m))
            ]),
            Shipment.Create("Ana Paula Lima", "09530-000", "40301-110", 560.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Impressora Multifuncional", 8m, 1, true, new Dimensions(45m, 35m, 25m)),
                ShipmentItem.Create("Resma de Papel A4", 2.5m, 4, false, new Dimensions(30m, 21m, 10m))
            ]),
            Shipment.Create("Roberto Alves", "20040-020", "69050-001", 25000.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Equipamento de Ultrassom", 22m, 1, true, new Dimensions(55m, 40m, 50m))
            ]),
            Shipment.Create("Fernanda Costa", "60150-160", "01310-100", 1200.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Smartphone", 0.3m, 3, true, new Dimensions(16m, 8m, 1m)),
                ShipmentItem.Create("Capinha Protetora", 0.1m, 3, false, new Dimensions(17m, 9m, 1m))
            ]),
            Shipment.Create("Lucas Mendes", "80010-010", "30112-000", 4300.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Televisão 55\"", 20m, 1, true, new Dimensions(130m, 80m, 12m)),
                ShipmentItem.Create("Suporte de Parede", 3m, 1, false, new Dimensions(40m, 30m, 8m)),
                ShipmentItem.Create("Cabo HDMI 2m", 0.2m, 2, false, new Dimensions(20m, 10m, 3m))
            ]),
            Shipment.Create("Patrícia Rocha", "01310-100", "60150-160", 680.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Tênis Esportivo", 1.2m, 2, false, new Dimensions(35m, 22m, 14m))
            ]),
            Shipment.Create("Diego Martins", "69050-001", "80010-010", 8750.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Drone Profissional", 4m, 1, true, new Dimensions(40m, 40m, 20m)),
                ShipmentItem.Create("Bateria Extra", 0.8m, 3, true, new Dimensions(15m, 8m, 4m)),
                ShipmentItem.Create("Maleta de Transporte", 2m, 1, false, new Dimensions(50m, 45m, 25m))
            ]),
            Shipment.Create("Juliana Teixeira", "01310-100", "80010-010", 320.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Livros Didáticos", 5m, 6, false, new Dimensions(25m, 18m, 5m))
            ]),
            Shipment.Create("Marcelo Oliveira", "30112-000", "09530-000", 15400.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Câmera DSLR", 1.8m, 1, true, new Dimensions(15m, 12m, 10m)),
                ShipmentItem.Create("Lente 50mm", 0.5m, 2, true, new Dimensions(10m, 10m, 8m)),
                ShipmentItem.Create("Tripé Profissional", 3.5m, 1, false, new Dimensions(60m, 12m, 12m))
            ]),
            Shipment.Create("Camila Barbosa", "40301-110", "60150-160", 2200.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Violão Eletroacústico", 4m, 1, true, new Dimensions(105m, 40m, 15m)),
                ShipmentItem.Create("Pedal de Efeito", 1m, 2, false, new Dimensions(15m, 12m, 6m))
            ]),
            Shipment.Create("Thiago Nascimento", "80010-010", "40301-110", 980.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Kit Ferramentas Elétricas", 7m, 1, false, new Dimensions(50m, 35m, 20m)),
                ShipmentItem.Create("Extensão 10m", 1.5m, 2, false, new Dimensions(20m, 20m, 10m))
            ]),
            Shipment.Create("Beatriz Carvalho", "09530-000", "20040-020", 45000.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Microscópio Eletrônico", 18m, 1, true, new Dimensions(40m, 35m, 55m)),
                ShipmentItem.Create("Kit Lâminas", 0.3m, 5, true, new Dimensions(10m, 8m, 2m))
            ]),
            Shipment.Create("Patrícia Nunes", "11013-001", "13010-111", 2750.50m, ShipmentPriority.Express, [
                ShipmentItem.Create("Placa de Vídeo", 1.8m, 1, true, new Dimensions(32m, 14m, 8m)),
                ShipmentItem.Create("Fonte ATX 750W", 2.2m, 1, false, new Dimensions(20m, 15m, 10m))
            ]),
            Shipment.Create("Eduardo Batista", "66053-000", "50030-230", 560.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Liquidificador", 3.4m, 1, true, new Dimensions(25m, 20m, 38m))
            ]),
            Shipment.Create("Juliana Martins", "79002-020", "69900-060", 120.90m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Camisetas", 0.9m, 5, false, new Dimensions(30m, 25m, 6m))
            ]),
            Shipment.Create("Rafael Teixeira", "64018-215", "01001-000", 18400.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Equipamento Médico", 28m, 1, true, new Dimensions(75m, 60m, 55m)),
                ShipmentItem.Create("Kit Sensores", 4.5m, 2, true, new Dimensions(30m, 22m, 18m))
            ]),
            Shipment.Create("Camila Rocha", "57020-670", "28950-000", 990.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Ventilador de Coluna", 6.7m, 1, false, new Dimensions(50m, 20m, 45m))
            ]),
            Shipment.Create("Beatriz Alencar", "13010-000", "22041-001", 4200.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("Placa de Vídeo RTX 4070", 1.8m, 1, true, new Dimensions(35m, 15m, 8m)),
                ShipmentItem.Create("Fonte Atx 750W", 2.5m, 1, false, new Dimensions(20m, 15m, 10m))
            ]),
            Shipment.Create("Eduardo Volpato", "80010-000", "88010-000", 150.00m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Mousepad Gamer Extra Grande", 0.8m, 2, false, new Dimensions(90m, 40m, 1m))
            ]),
            Shipment.Create("Hospital Central", "01153-000", "70040-010", 25000.00m, ShipmentPriority.NextDay, [
                ShipmentItem.Create("Equipamento Ultrassom Portátil", 12.0m, 1, true, new Dimensions(50m, 40m, 30m))
            ]),
            Shipment.Create("Livraria Saber", "30112-000", "60060-000", 1250.80m, ShipmentPriority.Normal, [
                ShipmentItem.Create("Lote de Livros Didáticos", 45.0m, 5, false, new Dimensions(40m, 40m, 40m))
            ]),
            Shipment.Create("Roberto Justos", "04578-000", "01310-100", 8900.00m, ShipmentPriority.Express, [
                ShipmentItem.Create("MacBook Air M2", 1.24m, 1, true, new Dimensions(30m, 21m, 2m)),
                ShipmentItem.Create("Adaptador USB-C Hub", 0.1m, 1, false, new Dimensions(10m, 5m, 2m))
            ])
        };

        await context.Shipments.AddRangeAsync(shipments);
        await context.SaveChangesAsync();
    }
}