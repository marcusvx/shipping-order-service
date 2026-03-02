using Microsoft.EntityFrameworkCore;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Web.Infrastructure.Persistence.Seeders;

public class ShipmentSeeder(ShipmentDbContext context)
{
    public async Task SeedAsync()
    {
        if (await context.Shipments.AnyAsync()) return;

        var shipments = new List<Shipment>
        {
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "João Silva",
                OriginZipCode = "01310-100",
                DestinationZipCode = "20040-020",
                TotalValue = 3500.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Monitor 27\"",
                        Weight = 6.5m,
                        Quantity = 2,
                        IsFragile = true,
                        Dimensions = new Dimensions(60m, 40m, 15m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Cadeira Gamer",
                        Weight = 18m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(70m, 120m, 70m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Maria Souza",
                OriginZipCode = "30112-000",
                DestinationZipCode = "01310-100",
                TotalValue = 800.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Notebook",
                        Weight = 2.5m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(35m, 25m, 3m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Carlos Ferreira",
                OriginZipCode = "40301-110",
                DestinationZipCode = "30112-000",
                TotalValue = 12000.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Servidor Rack",
                        Weight = 35m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(60m, 45m, 90m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Cabo de Rede Cat6",
                        Weight = 0.5m,
                        Quantity = 10,
                        IsFragile = false,
                        Dimensions = new Dimensions(10m, 10m, 5m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Ana Beatriz Oliveira",
                OriginZipCode = "80010-000",
                DestinationZipCode = "88010-000",
                TotalValue = 450.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Kit Teclado e Mouse Sem Fio",
                        Weight = 1.2m,
                        Quantity = 3,
                        IsFragile = false,
                        Dimensions = new Dimensions(50m, 20m, 5m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Tech Solutions LTDA",
                OriginZipCode = "04578-000",
                DestinationZipCode = "70040-010",
                TotalValue = 15200.50m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Projetor 4K profissional",
                        Weight = 4.8m,
                        Quantity = 2,
                        IsFragile = true,
                        Dimensions = new Dimensions(40m, 30m, 20m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Tela de Projeção Retrátil",
                        Weight = 12.0m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(220m, 15m, 15m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Ricardo Mendes",
                OriginZipCode = "60060-000",
                DestinationZipCode = "01310-100",
                TotalValue = 2100.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Smartphone High-End",
                        Weight = 0.4m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(18m, 10m, 5m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Capa Protetora e Película",
                        Weight = 0.1m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(15m, 8m, 1m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Fernanda Lima",
                OriginZipCode = "90010-000",
                DestinationZipCode = "22041-001",
                TotalValue = 540.25m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Luminária de Mesa Articulada",
                        Weight = 2.1m,
                        Quantity = 2,
                        IsFragile = true,
                        Dimensions = new Dimensions(30m, 30m, 50m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Logistics Corp",
                OriginZipCode = "32210-110",
                DestinationZipCode = "50010-000",
                TotalValue = 980.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Impressora Térmica de Etiquetas",
                        Weight = 3.5m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(25m, 20m, 20m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Bobinas Térmicas (Caixa)",
                        Weight = 5.0m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(30m, 30m, 30m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Ana Pereira",
                OriginZipCode = "22290-240",
                DestinationZipCode = "04538-132",
                TotalValue = 1500.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Impressora Multifuncional",
                        Weight = 8.2m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(45m, 35m, 25m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Bruno Carvalho",
                OriginZipCode = "88010-400",
                DestinationZipCode = "70040-010",
                TotalValue = 420.75m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Fones de Ouvido",
                        Weight = 0.3m,
                        Quantity = 3,
                        IsFragile = true,
                        Dimensions = new Dimensions(15m, 10m, 8m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Mouse sem fio",
                        Weight = 0.2m,
                        Quantity = 2,
                        IsFragile = false,
                        Dimensions = new Dimensions(12m, 8m, 5m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Fernanda Alves",
                OriginZipCode = "64000-000",
                DestinationZipCode = "59010-200",
                TotalValue = 9800.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Smart TV 65\"",
                        Weight = 24m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(160m, 95m, 20m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Soundbar",
                        Weight = 6m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(110m, 15m, 12m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Ricardo Gomes",
                OriginZipCode = "69005-070",
                DestinationZipCode = "80010-000",
                TotalValue = 230.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Livro Técnico",
                        Weight = 1.1m,
                        Quantity = 4,
                        IsFragile = false,
                        Dimensions = new Dimensions(23m, 16m, 12m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Ana Paula Lima",
                OriginZipCode = "09530-000",
                DestinationZipCode = "40301-110",
                TotalValue = 560.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Impressora Multifuncional", Weight = 8m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(45m, 35m, 25m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Resma de Papel A4", Weight = 2.5m, Quantity = 4,
                        IsFragile = false, Dimensions = new Dimensions(30m, 21m, 10m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Roberto Alves",
                OriginZipCode = "20040-020",
                DestinationZipCode = "69050-001",
                TotalValue = 25000.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Equipamento de Ultrassom", Weight = 22m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(55m, 40m, 50m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Fernanda Costa",
                OriginZipCode = "60150-160",
                DestinationZipCode = "01310-100",
                TotalValue = 1200.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Smartphone", Weight = 0.3m, Quantity = 3, IsFragile = true,
                        Dimensions = new Dimensions(16m, 8m, 1m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Capinha Protetora", Weight = 0.1m, Quantity = 3,
                        IsFragile = false, Dimensions = new Dimensions(17m, 9m, 1m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Lucas Mendes",
                OriginZipCode = "80010-010",
                DestinationZipCode = "30112-000",
                TotalValue = 4300.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Televisão 55\"", Weight = 20m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(130m, 80m, 12m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Suporte de Parede", Weight = 3m, Quantity = 1,
                        IsFragile = false, Dimensions = new Dimensions(40m, 30m, 8m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Cabo HDMI 2m", Weight = 0.2m, Quantity = 2,
                        IsFragile = false, Dimensions = new Dimensions(20m, 10m, 3m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Patrícia Rocha",
                OriginZipCode = "01310-100",
                DestinationZipCode = "60150-160",
                TotalValue = 680.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Tênis Esportivo", Weight = 1.2m, Quantity = 2,
                        IsFragile = false, Dimensions = new Dimensions(35m, 22m, 14m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Diego Martins",
                OriginZipCode = "69050-001",
                DestinationZipCode = "80010-010",
                TotalValue = 8750.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Drone Profissional", Weight = 4m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(40m, 40m, 20m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Bateria Extra", Weight = 0.8m, Quantity = 3,
                        IsFragile = true, Dimensions = new Dimensions(15m, 8m, 4m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Maleta de Transporte", Weight = 2m, Quantity = 1,
                        IsFragile = false, Dimensions = new Dimensions(50m, 45m, 25m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Juliana Teixeira",
                OriginZipCode = "01310-100",
                DestinationZipCode = "80010-010",
                TotalValue = 320.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Livros Didáticos", Weight = 5m, Quantity = 6,
                        IsFragile = false, Dimensions = new Dimensions(25m, 18m, 5m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Marcelo Oliveira",
                OriginZipCode = "30112-000",
                DestinationZipCode = "09530-000",
                TotalValue = 15400.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Câmera DSLR", Weight = 1.8m, Quantity = 1, IsFragile = true,
                        Dimensions = new Dimensions(15m, 12m, 10m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Lente 50mm", Weight = 0.5m, Quantity = 2, IsFragile = true,
                        Dimensions = new Dimensions(10m, 10m, 8m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Tripé Profissional", Weight = 3.5m, Quantity = 1,
                        IsFragile = false, Dimensions = new Dimensions(60m, 12m, 12m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Camila Barbosa",
                OriginZipCode = "40301-110",
                DestinationZipCode = "60150-160",
                TotalValue = 2200.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Violão Eletroacústico", Weight = 4m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(105m, 40m, 15m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Pedal de Efeito", Weight = 1m, Quantity = 2,
                        IsFragile = false, Dimensions = new Dimensions(15m, 12m, 6m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Thiago Nascimento",
                OriginZipCode = "80010-010",
                DestinationZipCode = "40301-110",
                TotalValue = 980.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Kit Ferramentas Elétricas", Weight = 7m, Quantity = 1,
                        IsFragile = false, Dimensions = new Dimensions(50m, 35m, 20m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Extensão 10m", Weight = 1.5m, Quantity = 2,
                        IsFragile = false, Dimensions = new Dimensions(20m, 20m, 10m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Beatriz Carvalho",
                OriginZipCode = "09530-000",
                DestinationZipCode = "20040-020",
                TotalValue = 45000.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Microscópio Eletrônico", Weight = 18m, Quantity = 1,
                        IsFragile = true, Dimensions = new Dimensions(40m, 35m, 55m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(), Description = "Kit Lâminas", Weight = 0.3m, Quantity = 5, IsFragile = true,
                        Dimensions = new Dimensions(10m, 8m, 2m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Patrícia Nunes",
                OriginZipCode = "11013-001",
                DestinationZipCode = "13010-111",
                TotalValue = 2750.50m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Placa de Vídeo",
                        Weight = 1.8m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(32m, 14m, 8m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Fonte ATX 750W",
                        Weight = 2.2m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(20m, 15m, 10m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Eduardo Batista",
                OriginZipCode = "66053-000",
                DestinationZipCode = "50030-230",
                TotalValue = 560.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Liquidificador",
                        Weight = 3.4m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(25m, 20m, 38m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Juliana Martins",
                OriginZipCode = "79002-020",
                DestinationZipCode = "69900-060",
                TotalValue = 120.90m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Camisetas",
                        Weight = 0.9m,
                        Quantity = 5,
                        IsFragile = false,
                        Dimensions = new Dimensions(30m, 25m, 6m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Rafael Teixeira",
                OriginZipCode = "64018-215",
                DestinationZipCode = "01001-000",
                TotalValue = 18400.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Equipamento Médico",
                        Weight = 28m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(75m, 60m, 55m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Kit Sensores",
                        Weight = 4.5m,
                        Quantity = 2,
                        IsFragile = true,
                        Dimensions = new Dimensions(30m, 22m, 18m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Camila Rocha",
                OriginZipCode = "57020-670",
                DestinationZipCode = "28950-000",
                TotalValue = 990.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Ventilador de Coluna",
                        Weight = 6.7m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(50m, 20m, 45m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Beatriz Alencar",
                OriginZipCode = "13010-000",
                DestinationZipCode = "22041-001",
                TotalValue = 4200.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Placa de Vídeo RTX 4070",
                        Weight = 1.8m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(35m, 15m, 8m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Fonte Atx 750W",
                        Weight = 2.5m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(20m, 15m, 10m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Eduardo Volpato",
                OriginZipCode = "80010-000",
                DestinationZipCode = "88010-000",
                TotalValue = 150.00m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Mousepad Gamer Extra Grande",
                        Weight = 0.8m,
                        Quantity = 2,
                        IsFragile = false,
                        Dimensions = new Dimensions(90m, 40m, 1m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Hospital Central",
                OriginZipCode = "01153-000",
                DestinationZipCode = "70040-010",
                TotalValue = 25000.00m,
                Priority = ShipmentPriority.NextDay,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Equipamento Ultrassom Portátil",
                        Weight = 12.0m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(50m, 40m, 30m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Livraria Saber",
                OriginZipCode = "30112-000",
                DestinationZipCode = "60060-000",
                TotalValue = 1250.80m,
                Priority = ShipmentPriority.Normal,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Lote de Livros Didáticos",
                        Weight = 45.0m,
                        Quantity = 5,
                        IsFragile = false,
                        Dimensions = new Dimensions(40m, 40m, 40m)
                    }
                ]
            },
            new Shipment
            {
                Id = Guid.NewGuid(),
                CustomerName = "Roberto Justos",
                OriginZipCode = "04578-000",
                DestinationZipCode = "01310-100",
                TotalValue = 8900.00m,
                Priority = ShipmentPriority.Express,
                Items =
                [
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "MacBook Air M2",
                        Weight = 1.24m,
                        Quantity = 1,
                        IsFragile = true,
                        Dimensions = new Dimensions(30m, 21m, 2m)
                    },
                    new ShipmentItem
                    {
                        Id = Guid.NewGuid(),
                        Description = "Adaptador USB-C Hub",
                        Weight = 0.1m,
                        Quantity = 1,
                        IsFragile = false,
                        Dimensions = new Dimensions(10m, 5m, 2m)
                    }
                ]
            }
        };

        await context.Shipments.AddRangeAsync(shipments);
        await context.SaveChangesAsync();
    }
}