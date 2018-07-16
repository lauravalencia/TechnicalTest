var newPoliza = (function () {

    var variables =
        {
            HtmlId:
                {
                    nombrepoliza: "nombrepoliza",
                    descpoliza: "descpoliza",
                    fechavigencia: "fechavigencia",
                    precio: "precio",
                    selectTipoRiesgo:"selectTipoRiesgo"

                },
            htmlStyles:
                {
                    none: "none",
                    empty: ""
                },
            selectedState: "",

        };

    var init = function () {

        submitForm();
        setRiskTypes();
    };
    var setRiskTypes = function () {
        utilities.callAjax(
            {
                url: '/api/RiskType/GetAll',
                type: "GET",
                errorFunction: function (data) {
                    console.log(data);
                    var msg = "Ha ocurrido un error, comunicarse con el administrador";
                    window.location.href = "/";
                },
                successFunction: function (data) {
                    if (data.OperationSuccess) {
                        var selectRiskType = $("#" + variables.HtmlId.selectTipoRiesgo);
                        var option = '';

                        for (var i = 0; i < data.ObjectResponse.TiposRiesgo.length; i++)
                        {
                            option += '<option value="' + data.ObjectResponse.TiposRiesgo[i].Id + '">' + data.ObjectResponse.TiposRiesgo[i].Name + '</option>';
                        } 

                        selectRiskType.append(option);

                    }
                    else if (!data.OperationSuccess && data.ErrorMessage !== null) {
                        console.log(data.ErrorMessage);
                    }
                }
            });
    };
    var submitForm = function () {
        $('form#form-main').on('submit', function (event) {
            event.preventDefault();
            debugger
            if ($('form#form-main').valid()) {
                if (validateData()) {
                    sendFormAndSerialize();
                }
            }
        });
    };
    var validateData = function () {

    };
    var sendFormAndSerialize = function () {
       
    };
    return {
        init: init,
    }
})();
