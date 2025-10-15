using Microsoft.EntityFrameworkCore.Migrations;

namespace FixItNow.Migrations
{
    public partial class AddMoreServicesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 18, "Baby Proofing" },
                    { 32, "Contactless Tasks" },
                    { 31, "Office Services" },
                    { 30, "Virtual & Online" },
                    { 29, "IKEA Services" },
                    { 28, "Delivery & Errands" },
                    { 27, "Organization" },
                    { 26, "Junk Removal" },
                    { 25, "Packing & Moving Help" },
                    { 24, "Doorbell & Home Theater" },
                    { 23, "Fence & Deck" },
                    { 22, "Wallpapering" },
                    { 21, "Cabinets" },
                    { 20, "Light Installation" },
                    { 19, "Yardwork & Landscaping" },
                    { 33, "Holidays & Seasonal" },
                    { 34, "Winter Tasks" },
                    { 16, "Shelves & Hooks" },
                    { 15, "Painting" },
                    { 14, "Smart Home" },
                    { 13, "Windows & Blinds" },
                    { 12, "Sealing & Caulking" },
                    { 11, "Flooring & Tiling" },
                    { 10, "General Mounting" },
                    { 9, "Personal Assistant" },
                    { 8, "Home Cleaning" },
                    { 7, "Heavy Lifting" },
                    { 6, "Home Repairs" },
                    { 5, "Furniture Assembly" },
                    { 17, "Maintenance" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 12, 3, "Move furniture within or between homes", "Furniture Movers", 1200m },
                    { 9, 2, "Mount and connect water filters", "Install Water Filter", 700m },
                    { 6, 1, "Install new ceiling fans", "Ceiling Fan Installation", 650m }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 14, 5, "Assemble outdoor sets", "Patio Furniture Assembly", 600m },
                    { 25, 13, "Repair window hardware & blinds", "Window & Blinds Repair", 450m },
                    { 7, 14, "Install smart switches and dimmers", "Smart Switch/Dimmer Setup", 550m },
                    { 42, 14, "Set up smart devices/hubs", "Smart Home Installation", 1200m },
                    { 40, 15, "Paint rooms and interiors", "Interior Painting", 2500m },
                    { 20, 16, "Install shelves and closet rods", "Install Shelves, Rods & Hooks", 350m },
                    { 32, 19, "Planting, weeding, pruning", "Gardening Services", 700m },
                    { 33, 19, "Mow and edge lawns", "Lawn Care & Mowing", 600m },
                    { 34, 19, "Clear and flush gutters", "Gutter Cleaning", 550m },
                    { 5, 20, "Install or replace light fixtures", "Light Installation", 450m },
                    { 35, 23, "Install or fix fences", "Fence Installation & Repair", 2000m },
                    { 10, 25, "Assist with packing, loading, unloading", "Help Moving", 1500m },
                    { 13, 26, "Pickup and dispose unwanted items", "Junk Pickup", 900m },
                    { 36, 27, "Declutter and organize closets", "Closet Organization", 700m },
                    { 38, 28, "Queue on your behalf", "Wait in Line", 250m },
                    { 39, 28, "Shop and deliver groceries", "Grocery Shopping & Delivery", 300m },
                    { 21, 13, "Mount blinds and curtains", "Install Blinds & Window Treatments", 500m },
                    { 43, 33, "Install and remove lights", "Hang Christmas Lights", 700m },
                    { 8, 12, "Seal bathtubs, sinks, windows", "Sealing & Caulking", 350m },
                    { 23, 10, "Mounting for various items", "General Mounting", 300m },
                    { 15, 5, "Assemble office and gaming desks", "Desk Assembly", 450m },
                    { 16, 5, "Assemble dressers and chests", "Dresser Assembly", 500m },
                    { 17, 5, "Assemble beds and frames", "Bed Assembly", 550m },
                    { 18, 5, "Assemble bookshelves and storage units", "Bookshelf Assembly", 400m },
                    { 19, 5, "Assemble wardrobes/closets", "Wardrobe Assembly", 700m },
                    { 24, 6, "Patch and smooth drywall", "Drywall Repair", 650m },
                    { 26, 6, "Fix hinges, handles, drawers", "Door, Cabinet, & Furniture Repair", 550m },
                    { 27, 6, "Install or fix appliances", "Appliance Installation & Repairs", 900m },
                    { 11, 7, "Move heavy furniture and appliances", "Heavy Lifting", 800m },
                    { 28, 8, "Standard home cleaning", "House Cleaning", 800m },
                    { 29, 8, "Intensive deep clean", "Deep Cleaning", 1200m },
                    { 30, 8, "Cleaning for moving", "Move In/Out Cleaning", 1000m },
                    { 31, 8, "Shampoo and clean carpets", "Carpet Cleaning", 900m },
                    { 37, 9, "Errands, scheduling, admin tasks", "Personal Assistant", 500m },
                    { 22, 10, "Mount frames, mirrors, and decor", "Hang Art, Mirror & Decor", 300m },
                    { 41, 11, "Install or repair tiles/flooring", "Flooring & Tiling Help", 3000m },
                    { 44, 34, "Clear snow from paths and drives", "Snow Removal", 900m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ServiceCategories",
                keyColumn: "Id",
                keyValue: 34);
        }
    }
}
