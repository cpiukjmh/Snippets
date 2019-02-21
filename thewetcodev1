            var u = User.Identity.Name;
            var HCquery = xdoc.Descendants("Publishers").Descendants("Publisher")
                .Where(x => x.Attribute("id").Value == "HARCOL");
            var harpcol =
                new DeliveryViewModel()
                {
                    PaperTypes = from h in HCquery.Descendants("PaperType")
                                 select new PaperViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     PaperGSM = int.Parse(h.Element("PaperGSM").Value),
                                     PaperMicrons = int.Parse(h.Element("PaperMicrons").Value),
                                 },
                    BookFormats = from h in HCquery.Descendants("BookFormat")
                                  select new BookFormatViewModel()
                                  {
                                      Name = h.Element("Format").Value,
                                      tpsLength = int.Parse(h.Element("Length").Value),
                                      tpsWidth = int.Parse(h.Element("Width").Value),
                                  },
                    CoverTypes = from h in HCquery.Descendants("CoverType")
                                 select new CoverBoardViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     CoverGSM = int.Parse(h.Element("CoverGSM").Value),

                                 },
                    JacketTypes = from h in HCquery.Descendants("JacketType")
                                  select new JacketTypesViewModel()
                                  {
                                      Name = h.Element("Name").Value,
                                      JacketGSM = int.Parse(h.Element("JacketGSM").Value),

                                  },

                };

            var BBquery = xdoc.Descendants("Publishers").Descendants("Publisher")
                .Where(x => x.Attribute("id").Value == "BLOOMS");
            var blooms =
                new DeliveryViewModel()
                {
                    PaperTypes = from h in BBquery.Descendants("PaperType")
                                 select new PaperViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     PaperGSM = int.Parse(h.Element("PaperGSM").Value),
                                     PaperMicrons = int.Parse(h.Element("PaperMicrons").Value),
                                 },
                    BookFormats = from h in BBquery.Descendants("BookFormat")
                                  select new BookFormatViewModel()
                                  {
                                      Name = h.Element("Format").Value,
                                      tpsLength = int.Parse(h.Element("Length").Value),
                                      tpsWidth = int.Parse(h.Element("Width").Value),
                                  },
                    CoverTypes = from h in BBquery.Descendants("CoverType")
                                 select new CoverBoardViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     CoverGSM = int.Parse(h.Element("CoverGSM").Value),

                                 },
                    JacketTypes = from h in BBquery.Descendants("JacketType")
                                  select new JacketTypesViewModel()
                                  {
                                      Name = h.Element("Name").Value,
                                      JacketGSM = int.Parse(h.Element("JacketGSM").Value),

                                  },

                };

            var SSquery = xdoc.Descendants("Publishers").Descendants("Publisher")
                .Where(x => x.Attribute("id").Value == "SIMSCH");
            var simsch =
                new DeliveryViewModel()
                {
                    PaperTypes = from h in SSquery.Descendants("PaperType")
                                 select new PaperViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     PaperGSM = int.Parse(h.Element("PaperGSM").Value),
                                     PaperMicrons = int.Parse(h.Element("PaperMicrons").Value),
                                 },
                    BookFormats = from h in SSquery.Descendants("BookFormat")
                                  select new BookFormatViewModel()
                                  {
                                      Name = h.Element("Format").Value,
                                      tpsLength = int.Parse(h.Element("Length").Value),
                                      tpsWidth = int.Parse(h.Element("Width").Value),
                                  },
                    CoverTypes = from h in SSquery.Descendants("CoverType")
                                 select new CoverBoardViewModel()
                                 {
                                     Name = h.Element("Name").Value,
                                     CoverGSM = int.Parse(h.Element("CoverGSM").Value),

                                 },
                    JacketTypes = from h in SSquery.Descendants("JacketType")
                                  select new JacketTypesViewModel()
                                  {
                                      Name = h.Element("Name").Value,
                                      JacketGSM = int.Parse(h.Element("JacketGSM").Value),

                                  },

                };

            
        }
