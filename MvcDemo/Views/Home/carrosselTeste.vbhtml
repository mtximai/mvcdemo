@* Data: 06/12/16 *@

@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Styles.Render("~/Scripts/slick-1.6.0/slick/slick.css")
@Styles.Render("~/Scripts/slick-1.6.0/slick/slick-theme.css")

@Scripts.Render("~/Scripts/slick-1.6.0/slick/slick.min.js")


<style type="text/css">
	div.carouselBotoesConfig {
		/*display: inline;*/
		/*display: table-cell;*/

		text-align: center;
		vertical-align: middle;
	}

	div.carouselBotoesConfig > a > img {
		margin: 10px 0px 0px 0px;
		max-width: 90px;
		width: 100%;
		display: inline;

	}

</style>


<h3>Teste com Carousel</h3>

<div class="col-md-7" style="background-color: lightgray">

	<div class="autoplay " style="background-color:lightgreen; margin-left:20px; margin-right:20px; margin-top:20px">

		@code
			Dim botoes As New List(Of KeyValuePair(Of String, String))

			botoes.Add(New KeyValuePair(Of String, String)("Consolidar", "/Content/Images/Icone_Consolidar.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Dialogar", "/Content/Images/Icone_Dialogar.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Email", "/Content/Images/Icone_Email.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Grupos", "/Content/Images/Icone_Grupos.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Manter", "/Content/Images/Icone_Manter.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Publicar", "/Content/Images/Icone_Publicar.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Questões", "/Content/Images/Icone_Questoes.png"))
			botoes.Add(New KeyValuePair(Of String, String)("Usuário", "/Content/Images/Icone_Usuarios.png"))

		End Code

		@For Each i In botoes

			@<div class="carouselBotoesConfig">
				<a class="text-center" href="#aa">
					<img src="@i.Value" />
					<p style="font-size: 18px; text-align:center">@i.Key</p>
				</a>
			</div>

		  Next

	</div>

</div>


<script>
	
	$(document).ready(function () {

		$('.autoplay').slick({

			slidesToShow: 3,
			slidesToScroll: 1,
			autoplay: true,
			autoplaySpeed: 2000,
			dots: true

		});


		$('.responsive').slick({
			dots: true,
			infinite: false,
			speed: 300,
			slidesToShow: 4,
			slidesToScroll: 2,
			responsive: [
			  {
			  	breakpoint: 1024,
			  	settings: {
			  		slidesToShow: 3,
			  		slidesToScroll: 3,
			  		infinite: true,
			  		dots: true
			  	}
			  },
			  {
			  	breakpoint: 600,
			  	settings: {
			  		slidesToShow: 2,
			  		slidesToScroll: 2
			  	}
			  },
			  {
			  	breakpoint: 480,
			  	settings: {
			  		slidesToShow: 1,
			  		slidesToScroll: 1
			  	}
			  }
			  // You can unslick at a given breakpoint now by adding:
			  // settings: "unslick"
			  // instead of a settings object
			]
		});


		$('.single-item').slick();


		$('.fade').slick({
			dots: true,
			infinite: true,
			speed: 500,
			fade: true,
			cssEase: 'linear'
		});

		$('.filtering').slick({
			slidesToShow: 4,
			slidesToScroll: 4
		});


		$('.multiple-items').slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 3
		});

		$('.variable-width').slick({
			dots: true,
			infinite: true,
			speed: 300,
			slidesToShow: 1,
			centerMode: true,
			variableWidth: true
		});



		$('.center').slick({
			dots: true,
			slidesToShow: 3,
			slidesToScroll: 1,
		});

	});

</script>