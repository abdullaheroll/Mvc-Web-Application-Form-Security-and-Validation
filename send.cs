// Verify inputs
                if (!Regex.IsMatch(name, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    return Json(new
                    {
                        success = false,
                        message = "Invalid email format."
                    });
                }

                // Escape inputs
                name = HttpUtility.HtmlEncode(name);

                // Check anti-CSRF token
                string csrfToken = Request.Form["csrfToken"];

                if (!string.Equals(csrfToken, HttpContext.Session["csrfToken"]))
                {
                    return Json(new
                    {
                        success = false,
                        message = "Invalid anti-CSRF token."
                    });
                }
